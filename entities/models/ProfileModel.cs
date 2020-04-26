using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;

namespace SmsDotNet.Entities
{
    class ProfileModel
    {
        [ForeignKey("User")]
        public int idOwner { get; set; }
        public UserModel owner { get; set; }

        public string image { get; set; }
    }
}
