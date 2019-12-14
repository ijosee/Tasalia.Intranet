using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class Visited
    {
        public Visited()
        {
            AppraisalInfo = new HashSet<AppraisalInfo>();
        }

        public int VisitedId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string Visited1 { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppraisalInfo> AppraisalInfo { get; set; }
    }
}
