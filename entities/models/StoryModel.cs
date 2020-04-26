using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmsDotNet.Entities
{
    class Story
    {
        [ForeignKey("User")]
        public int IdOwner { get; set; }
        public UserModel Owner { get; set; }

        [Required (ErrorMessage = "Campo obrigatório")]
        public string Message { get; set; }

        public DateTime PostDate { get; set; }

    }
}
