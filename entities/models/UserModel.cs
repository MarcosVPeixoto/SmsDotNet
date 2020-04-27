using System.ComponentModel.DataAnnotations;

namespace SmsDotNet.Entities
{
    public class UserModel : AuditModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(60, ErrorMessage = "Máximo de 60 caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(60, ErrorMessage = "Máximo de 60 caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(60, ErrorMessage = "Máximo de 60 caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Campo obrigatório")]
        public string Password { get; set; }

        public string ImageUrl { get; set; }
    }
}