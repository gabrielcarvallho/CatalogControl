# CatalogControl

## Objetivo

O **CatalogControl** é uma API REST desenvolvida em .NET para gerenciamento de categorias e produtos. O projeto foi desenvolvido com foco nos principais conceitos de Clean Architecture e Domain-Driven Design (DDD), garantindo uma estrutura escalável e organizada.

---

## Arquitetura

O projeto foi desenvolvido com base nos princípios de Clean Architecture e Domain-Driven Design (DDD), organizando as responsabilidades em camadas bem definidas para garantir manutenibilidade, testabilidade, escalabilidade e foco no domínio do negócio.

- **Domain**: Entidades de negócio e interfaces de repositórios/serviços.
- **Application**: DTOs, serviços de aplicação, validações e mapeamentos.
- **Infrastructure**: Implementação de repositórios, contexto do banco de dados (EF Core) e injeção de dependências.
- **Api**: Camada de apresentação (controllers), configuração do Swagger, middlewares e inicialização da aplicação.

---

## Estrutura de Pastas

```
CatalogControl/
├── CatalogControl.Api/           # Camada de apresentação (Web API)
│   ├── Controllers/              # Controllers REST
│   ├── Middleware/               # Middlewares globais
│   ├── appsettings.json          # Configurações da aplicação
│   └── Program.cs                # Inicialização da aplicação
├── CatalogControl.Application/   # Camada de aplicação
│   ├── DTOs/                     # Data Transfer Objects
│   ├── Mappings/                 # Perfis do AutoMapper
│   ├── Services/                 # Interfaces de serviços de aplicação
│   ├── Validators/               # Validações com FluentValidation
│   └── DependencyInjection.cs    # Injeção de dependências
├── CatalogControl.Domain/        # Camada de domínio
│   ├── Entities/                 # Entidades de domínio
│   └── Repositories/             # Interfaces de repositórios
├── CatalogControl.Infrastructure/# Infraestrutura (EF Core, repositórios)
│   ├── Data/                     # Contexto do banco e configurações
│   ├── Migrations/               # Migrations do banco de dados
│   ├── Repositories/             # Implementações dos repositórios
│   ├── Services/                 # Implementações dos serviços de aplicação
│   └── DependencyInjection.cs    # Injeção de dependências
├── docker-compose.yml            # (Opcional) PostgreSQL em Container
└── CatalogControl.sln            # Solução do Visual Studio
```

---

## Como Executar o Projeto

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/) (ou utilize o docker-compose)
- (Opcional) [Docker Compose](https://docs.docker.com/compose/)

### 1. Configuração do Banco de Dados

O projeto utiliza PostgreSQL. O arquivo `appsettings.Development.json` possui uma string de conexão padrão:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5433;Database=catalog_db;Username=postgres;Password=MyStrong!Passw0rd;"
}
```

Altere conforme necessário.

#### Usando Docker Compose

Se preferir, suba o banco com Docker:

```sh
docker-compose up -d
```

### 2. Aplicando as Migrations

No diretório da solução, execute:

```sh
dotnet ef database update --project CatalogControl.Infrastructure --startup-project CatalogControl.Api
```

### 3. Executando a API

No diretório da solução, rode:

```sh
dotnet run --project CatalogControl.Api
```

A API estará disponível em `https://localhost:7043` ou `http://localhost:5225`.

### 4. Documentação Swagger

Acesse `/swagger` na URL da API para visualizar e testar os endpoints.

---
## Tecnologias Utilizadas

- .NET Core 8
- Entity Framework Core (PostgreSQL)
- AutoMapper
- FluentValidation
- Swagger (Swashbuckle)
---