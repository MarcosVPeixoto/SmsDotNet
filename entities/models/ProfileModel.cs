using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;

namespace entities.models
{
    class ProfileModel
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("User")]
        public int idOwner { get; set; }
        public UserModel owner { get; set; }

        public string image { get; set; }
    }
}
