using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entities.models
{
    class MessageModel
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("User")]
        public int idOwner { get; set; }
        public UserModel owner { get; set; }

        [ForeignKey("User")]
        public int idTarget { get; set; }
        public UserModel target { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string message { get; set; }

        public ReadableBy status { get; set; }

        public DateTime date { get; set; }
    }

    enum ReadableBy
    {
        all,
        owner,
        target,
        nobody
    }
}
