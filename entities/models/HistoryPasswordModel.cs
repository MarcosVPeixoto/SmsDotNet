
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmsDotNet.Entities
{
    class HistoryPasswordModel
    {        
        [ForeignKey("User")]
        public int IdOwner { get; set; }
        public UserModel Owner { get; set; }

    }
}
