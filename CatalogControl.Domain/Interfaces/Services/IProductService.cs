using CatalogControl.Domain.Entities;

namespace CatalogControl.Domain.Interfaces.Services;

public interface IProductService
{
    Task<Product?> GetByIdAsync(Guid id);
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product> CreateAsync(Product product);
    Task<Product> UpdateAsync(Product product);
    Task<Product> DeleteAsync(Guid id);
    Task<bool> ExistsAsync(Guid id);
}