using CatalogControl.Application.DTOs;

namespace CatalogControl.Domain.Interfaces.Services;

public interface IProductService
{
    Task<ProductResponseDto?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProductResponseDto>> GetAllAsync();
    Task<ProductResponseDto?> CreateAsync(ProductRequestDto productDto);
    Task<ProductResponseDto?> UpdateAsync(Guid id, ProductRequestDto productDto);
    Task<bool> DeleteAsync(Guid id);
}