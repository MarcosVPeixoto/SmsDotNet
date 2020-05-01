using System.ComponentModel.DataAnnotations.Schema;

namespace SmsDotNet.Entities
{
    public class ContactModel : AuditModel
    {
        [ForeignKey("User")]
        public int IdOwner { get; set; }
        public virtual UserModel Owner { get; set; }

        [ForeignKey("User")]
        public int IdTarget { get; set; }
        public virtual UserModel Target { get; set; }
    }
}
