using AutoMapper;
using CatalogControl.Application.DTOs;
using CatalogControl.Application.Services;
using CatalogControl.Domain.Entities;
using CatalogControl.Domain.Repositories;

namespace CatalogControl.Infrastructure.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<CategoryResponseDto?> GetByIdAsync(Guid id)
    {
        var category = await _categoryRepository.GetByIdAsync(id);
        return category == null ? null : _mapper.Map<CategoryResponseDto>(category);
    }

    public async Task<IEnumerable<CategoryResponseDto>> GetAllAsync()
    {
        var categories = await _categoryRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<CategoryResponseDto>>(categories);
    }

    public async Task<CategoryResponseDto> CreateAsync(CategoryRequestDto categoryDto)
    {
        var category = _mapper.Map<Category>(categoryDto);
        var createdCategory = await _categoryRepository.CreateAsync(category);

        return _mapper.Map<CategoryResponseDto>(createdCategory);
    }

    public async Task<CategoryResponseDto?> UpdateAsync(Guid id, CategoryRequestDto categoryDto)
    {
        var category = await _categoryRepository.GetByIdAsync(id);
        if (category == null)
            return null;

        _mapper.Map(categoryDto, category);
        category.UpdatedAt = DateTime.UtcNow;

        var updatedCategory = await _categoryRepository.UpdateAsync(category);
        return _mapper.Map<CategoryResponseDto>(updatedCategory);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        if (!await _categoryRepository.ExistsAsync(id))
            return false;

        await _categoryRepository.DeleteAsync(id);
        return true;
    }
}