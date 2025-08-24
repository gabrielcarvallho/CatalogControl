using AutoMapper;
using CatalogControl.Application.DTOs;
using CatalogControl.Domain.Entities;
using CatalogControl.Domain.Interfaces.Services;
using CatalogControl.Domain.Repositories;

namespace CatalogControl.Infrastructure.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, ICategoryRepository categoryRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<ProductResponseDto?> GetByIdAsync(Guid id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        return product == null ? null : _mapper.Map<ProductResponseDto>(product);
    }

    public async Task<IEnumerable<ProductResponseDto>> GetAllAsync()
    {
        var categories = await _productRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<ProductResponseDto>>(categories);
    }

    public async Task<ProductResponseDto?> CreateAsync(ProductRequestDto productDto)
    {
        if (!await _categoryRepository.ExistsAsync(productDto.CategoryId))
            throw new ArgumentException("Category not found");

        var product = _mapper.Map<Product>(productDto);
        var createdProduct = await _productRepository.CreateAsync(product);

        return _mapper.Map<ProductResponseDto>(product);

    }

    public async Task<ProductResponseDto?> UpdateAsync(Guid id, ProductRequestDto productDto)
    {
        var product = await _productRepository.GetByIdAsync(id);
        if (product == null)
            return null;

        if (!await _categoryRepository.ExistsAsync(productDto.CategoryId))
            throw new ArgumentException("Category not found");

        _mapper.Map(productDto, product);
        product.UpdatedAt = DateTime.UtcNow;

        var updatedProduct = await _productRepository.UpdateAsync(product);
        return _mapper.Map<ProductResponseDto>(updatedProduct);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        if (!await _productRepository.ExistsAsync(id))
            return false;

        await _productRepository.DeleteAsync(id);
        return true;
    }
}