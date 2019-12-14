using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class Registry
    {
        public Registry()
        {
            AppraisalInfo = new HashSet<AppraisalInfo>();
        }

        public int RegistryId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string Registry1 { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppraisalInfo> AppraisalInfo { get; set; }
    }
}
