using System.ComponentModel.DataAnnotations;

namespace SmsDotNet.Entities
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
