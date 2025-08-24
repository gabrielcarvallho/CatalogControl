namespace CatalogControl.Application.DTOs;

public class CategoryRequestDto
{
    public string Name { get; set; } = string.Empty;
}

public class CategoryResponseDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<ProductResponseDto> Products { get; set; } = new List<ProductResponseDto>();
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}