using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class ConditionerAppraisalType
    {
        public ConditionerAppraisalType()
        {
            ConditioningAppraisal = new HashSet<ConditioningAppraisal>();
        }

        public int ConditionerAppraisalTypeId { get; set; }
        public string ConditionerAppraisalType1 { get; set; }
        public string Pattern { get; set; }

        public virtual ICollection<ConditioningAppraisal> ConditioningAppraisal { get; set; }
    }
}
