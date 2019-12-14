using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class Entity
    {
        public Entity()
        {
            AppraisalInfo = new HashSet<AppraisalInfo>();
            EntityBranch = new HashSet<EntityBranch>();
        }

        public int EntityId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string Entity1 { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppraisalInfo> AppraisalInfo { get; set; }
        public virtual ICollection<EntityBranch> EntityBranch { get; set; }
    }
}
