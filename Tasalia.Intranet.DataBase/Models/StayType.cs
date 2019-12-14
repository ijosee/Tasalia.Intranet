using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class StayType
    {
        public StayType()
        {
            AppraisalInfo = new HashSet<AppraisalInfo>();
        }

        public int StayTypeId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string StayType1 { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppraisalInfo> AppraisalInfo { get; set; }
    }
}
