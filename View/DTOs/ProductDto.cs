using System.ComponentModel.DataAnnotations;

namespace View.DTOs;

public class ProductDto
{
    [Required (ErrorMessage = "Поле не может быть пустым.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Поле не может быть пустым.")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Поле не может быть пустым.")]
    public int Price { get; set; }

    [Required(ErrorMessage = "Поле не может быть пустым.")]
    public double Rating { get; set; }
}
