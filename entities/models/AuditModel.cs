using System;

namespace SmsDotNet.Entities
{
    public abstract class AuditModel : BaseModel
    {
        public DateTime CeatedDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
