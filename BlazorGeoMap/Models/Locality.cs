using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorGeoMap.Models
{
    public class Locality
    {
        [Key]
        [MaxLength(7)]
        public string Id { get; set; } = string.Empty;

        [MaxLength(2, ErrorMessage = "O estado deve no máximo 2 caracteres")]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        [MinLength(3, ErrorMessage = "A cidade deve ter pelo menos 3 caracteres.")]
        public string City { get; set; } = string.Empty;
    }
}