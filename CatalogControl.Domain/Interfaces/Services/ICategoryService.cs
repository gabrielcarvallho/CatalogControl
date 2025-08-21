using CatalogControl.Domain.Entities;

namespace CatalogControl.Domain.Interfaces.Services;

public interface ICategoryService
{
    Task<Category?> GetByIdAsync(Guid id);
    Task<IEnumerable<Category>> GetAllAsync();
    Task<Category> CreateAsync(Category category);
    Task<Category> UpdateAsync(Category category);
    Task<Category> DeleteAsync(Guid id);
    Task<bool> ExistsAsync(Guid id);
}