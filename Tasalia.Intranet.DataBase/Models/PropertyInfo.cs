using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class PropertyInfo
    {
        public int PropertyInfoId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public int PropertyId { get; set; }
        public int? AppraisalInfoId { get; set; }
        public int? StreetTypeId { get; set; }
        public string Street { get; set; }
        public int? DataType1Id { get; set; }
        public string Data1 { get; set; }
        public int? DataType2Id { get; set; }
        public string Data2 { get; set; }
        public int? DataType3Id { get; set; }
        public string Data3 { get; set; }
        public int? DataType4Id { get; set; }
        public string Data4 { get; set; }
        public int? DistrictId { get; set; }
        public int? ZoneId { get; set; }
        public string BuildingCatastralReference { get; set; }
        public int? BuiltYear { get; set; }
        public int? Reform60Year { get; set; }
        public int? ReformYear { get; set; }
        public string CatastroNavarra { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual AppraisalInfo AppraisalInfo { get; set; }
        public virtual DataType DataType1 { get; set; }
        public virtual DataType DataType2 { get; set; }
        public virtual DataType DataType3 { get; set; }
        public virtual DataType DataType4 { get; set; }
        public virtual District District { get; set; }
        public virtual Property Property { get; set; }
        public virtual StreetType StreetType { get; set; }
        public virtual Zone Zone { get; set; }
    }
}
