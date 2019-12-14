using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class Appraisal
    {
        public Appraisal()
        {
            AppraisalInfo = new HashSet<AppraisalInfo>();
        }

        public int AppraisalId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string Number { get; set; }
        public int PropertyId { get; set; }
        public string Supplement { get; set; }
        public int? DeputationId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Deputation Deputation { get; set; }
        public virtual Property Property { get; set; }
        public virtual ICollection<AppraisalInfo> AppraisalInfo { get; set; }
    }
}
