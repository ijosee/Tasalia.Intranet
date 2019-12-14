using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class OccupantType
    {
        public OccupantType()
        {
            AppraisalInfo = new HashSet<AppraisalInfo>();
        }

        public int OccupantTypeId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string OccupantType1 { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppraisalInfo> AppraisalInfo { get; set; }
    }
}
