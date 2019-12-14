using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class MaterialAppraisal
    {
        public int MaterialAppraisalId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string MaterialAppraisal1 { get; set; }
        public int AppraisalInfoId { get; set; }
        public int? HouseZoneId { get; set; }
        public int MaterialTypeId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual AppraisalInfo AppraisalInfo { get; set; }
        public virtual HouseZone HouseZone { get; set; }
        public virtual MaterialType MaterialType { get; set; }
    }
}
