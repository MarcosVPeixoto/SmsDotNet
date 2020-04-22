
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entities.models
{
    class Story
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("User")]
        public int idOwner { get; set; }
        public UserModel owner { get; set; }

        [Required (ErrorMessage = "Campo obrigatório")]
        public string message { get; set; }

        public DateTime postDate { get; set; }

    }
}
