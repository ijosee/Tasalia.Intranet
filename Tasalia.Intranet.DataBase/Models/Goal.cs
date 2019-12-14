using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class Goal
    {
        public Goal()
        {
            AppraisalInfo = new HashSet<AppraisalInfo>();
        }

        public int GoalId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string Goal1 { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppraisalInfo> AppraisalInfo { get; set; }
    }
}
