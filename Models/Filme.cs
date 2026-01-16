using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FilmesApi.Models;

public class Filme
{
    public int Id { get; internal set; }
    [Required(ErrorMessage = "O título do filme é obrigatório.")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O diretor do filme é obrigatório.")]
    public string Diretor { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório.")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres.")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve estar entre 70 e 600 minutos.")]
    public int Duracao { get; set; }
}