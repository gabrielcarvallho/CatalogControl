using CatalogControl.Domain.Entities;
using CatalogControl.Domain.Interfaces.Services;

namespace CatalogControl.Infrastructure.Services;

public class CategoryService : ICategoryService
{
    public Task<Category> CreateAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public Task<Category> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Category>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Category?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Category> UpdateAsync(Category category)
    {
        throw new NotImplementedException();
    }
}