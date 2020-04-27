using System.ComponentModel.DataAnnotations.Schema;

namespace SmsDotNet.Entities
{
    public class ProfileModel : AuditModel
    {
        [ForeignKey("User")]
        public int IdOwner { get; set; }
        public UserModel Owner { get; set; }

        public string Image { get; set; }
    }
}
