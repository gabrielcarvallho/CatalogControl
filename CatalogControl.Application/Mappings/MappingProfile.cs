using AutoMapper;
using CatalogControl.Application.DTOs;
using CatalogControl.Domain.Entities;

namespace CatalogControl.Application.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // DTO -> Entity
        CreateMap<CategoryRequestDto, Category>();
        CreateMap<ProductRequestDto, Product>();

        // Entity -> DTO
        CreateMap<Category, CategoryResponseDto>()
            .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products));

        CreateMap<Product, ProductResponseDto>()
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
    }
}