using System.ComponentModel.DataAnnotations;

namespace entities.models
{
    public class UserModel
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo obrigat�rio")]
        [MaxLength(60, ErrorMessage = "M�ximo de 60 caracteres")]
        [MinLength(3, ErrorMessage = "M�nimo de 3 caracteres")]
        public string username { get; set; }
        
        [Required(ErrorMessage = "Campo obrigat�rio")]
        [MaxLength(60, ErrorMessage = "M�ximo de 60 caracteres")]
        [MinLength(3, ErrorMessage = "M�nimo de 3 caracteres")]
        public string name { get; set; }

        [Required(ErrorMessage = "Campo obrigat�rio")]
        [MaxLength(60, ErrorMessage = "M�ximo de 60 caracteres")]
        [MinLength(3, ErrorMessage = "M�nimo de 3 caracteres")]
        public string email { get; set; }

        [Required (ErrorMessage = "Campo obrigat�rio")]
        public string password { get; set; }

        public string imageUrl { get; set; }
    }
}