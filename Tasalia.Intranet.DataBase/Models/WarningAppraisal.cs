using System;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class WarningAppraisal
    {
        public int WarningAppraisalId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string WarningAppraisal1 { get; set; }
        public int? WarningAppraisalTypeId { get; set; }
        public int AppraisalInfoId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual AppraisalInfo AppraisalInfo { get; set; }
        public virtual WarningAppraisalType WarningAppraisalType { get; set; }
    }
}
