using CatalogControl.Domain.Entities;
using CatalogControl.Domain.Interfaces.Services;

namespace CatalogControl.Infrastructure.Services;

public class ProductService : IProductService
{
    public Task<Product> CreateAsync(Product product)
    {
        throw new NotImplementedException();
    }

    public Task<Product> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Product?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Product> UpdateAsync(Product product)
    {
        throw new NotImplementedException();
    }
}