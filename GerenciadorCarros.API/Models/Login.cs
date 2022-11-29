using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorCarros.API.Models
{
    public class Login
    {   
        [Required(ErrorMessage = "Informe seu email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Informe a sua senha")]
        public string? Password { get; set; }
    }
}


