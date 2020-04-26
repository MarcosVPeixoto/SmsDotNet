using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmsDotNet.Entities
{
    class ContactModel : AuditModel
    {
        [ForeignKey("User")]    
        public int IdOwner { get; set; }
        public UserModel Owner { get; set; }

        [ForeignKey("User")]
        public int IdTarget { get; set; }
        public UserModel Target { get; set; }
    }
}
