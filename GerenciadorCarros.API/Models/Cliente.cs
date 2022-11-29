using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorCarros.API.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayName("Nome")]
        public string? Name { get; set; }
                     
        [Column(TypeName = "varchar(11)")]
        [DisplayName("CPF")]
        public string? CPF { get; set; }
                     
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Email")]
        [Required(ErrorMessage = "Informe seu email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Informe a sua senha")]
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Password")]
        public string? Password { get; set; }
    }
}
