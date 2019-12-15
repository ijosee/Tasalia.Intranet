using System;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class AppraisalAcronym
    {
        public string AppraisalAcronymId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string AppraisalAcronym1 { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
