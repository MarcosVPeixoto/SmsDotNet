using System.ComponentModel.DataAnnotations;

namespace entities.models
{
    public class UserModel
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(60, ErrorMessage = "Máximo de 60 caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres")]
        public string username { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(60, ErrorMessage = "Máximo de 60 caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres")]
        public string name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(60, ErrorMessage = "Máximo de 60 caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres")]
        public string email { get; set; }

        [Required (ErrorMessage = "Campo obrigatório")]
        public string password { get; set; }

        public string imageUrl { get; set; }
    }
}