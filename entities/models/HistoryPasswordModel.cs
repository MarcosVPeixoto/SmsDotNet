using System.ComponentModel.DataAnnotations.Schema;

namespace SmsDotNet.Entities
{
    public class HistoryPasswordModel : AuditModel
    {        
        [ForeignKey("User")]
        public int IdOwner { get; set; }
        public UserModel Owner { get; set; }

    }
}
