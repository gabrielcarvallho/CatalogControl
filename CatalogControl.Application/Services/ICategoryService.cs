using CatalogControl.Application.DTOs;

namespace CatalogControl.Application.Services;

public interface ICategoryService
{
    Task<CategoryResponseDto?> GetByIdAsync(Guid id);
    Task<IEnumerable<CategoryResponseDto>> GetAllAsync();
    Task<CategoryResponseDto> CreateAsync(CategoryRequestDto categoryDto);
    Task<CategoryResponseDto?> UpdateAsync(Guid id, CategoryRequestDto categoryDto);
    Task<bool> DeleteAsync(Guid id);
}