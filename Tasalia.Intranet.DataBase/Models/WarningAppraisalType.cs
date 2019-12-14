using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class WarningAppraisalType
    {
        public WarningAppraisalType()
        {
            WarningAppraisal = new HashSet<WarningAppraisal>();
        }

        public int WarningAppraisalTypeId { get; set; }
        public string WarningAppraisalType1 { get; set; }
        public string Pattern { get; set; }

        public virtual ICollection<WarningAppraisal> WarningAppraisal { get; set; }
    }
}
