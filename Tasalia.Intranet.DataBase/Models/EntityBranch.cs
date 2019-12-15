using System;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class EntityBranch
    {
        public int EntityBranchId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string Code { get; set; }
        public string EntityBranch1 { get; set; }
        public int EntityId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Entity Entity { get; set; }
    }
}
