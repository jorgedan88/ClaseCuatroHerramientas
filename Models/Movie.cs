using System.ComponentModel.DataAnnotations;
namespace ClaseCuatroHerramientas.Models;

public class Movie{
    public string Code {get; set;}
    public int Minutes {get; set;}
    [Display(Name="NOMBRE")] [Required]
    public string Name {get; set;}
    public string Category {get; set;}
    public string Review {get; set;}
}