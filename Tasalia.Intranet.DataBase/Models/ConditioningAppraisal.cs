using System;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class ConditioningAppraisal
    {
        public int ConditionerAppraisalId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string ConditionerAppraisal { get; set; }
        public int? ConditionerAppraisalTypeId { get; set; }
        public int AppraisalInfoId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual AppraisalInfo AppraisalInfo { get; set; }
        public virtual ConditionerAppraisalType ConditionerAppraisalType { get; set; }
    }
}
