using System.ComponentModel.DataAnnotations;

public class CursoFormDto
{
    public int? Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    [MaxLength(80)]
    public string Codigo { get; set; } = string.Empty;

    [Required]
    [Range(1, 18, ErrorMessage = "Los créditos deben estar entre 1 y 18.")]
    public int Creditos { get; set; }

    public bool Activo { get; set; } = true;
}