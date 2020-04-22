
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entities.models
{
    class HistoryPasswordModel
    {
        [Key]
        public int id { get; set; }
        
        [ForeignKey("User")]
        public int idOwner { get; set; }
        public UserModel owner { get; set; }

    }
}
