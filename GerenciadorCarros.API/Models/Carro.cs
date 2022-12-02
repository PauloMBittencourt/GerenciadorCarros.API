using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorCarros.API.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayName("Modelo")]
        public string? Modelo { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayName("Ano")]
        public string? Ano { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Usado")]
        public bool Usado { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Preco")]
        public string Preco { get; set; }
    }
}
