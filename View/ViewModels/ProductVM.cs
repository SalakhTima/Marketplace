using System.ComponentModel.DataAnnotations;

namespace View.ViewModels;

public class ProductVM
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public int Price { get; set; }

    [Required]
    public double Rating { get; set; }
}
