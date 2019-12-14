using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class DataType
    {
        public DataType()
        {
            PropertyInfoDataType1 = new HashSet<PropertyInfo>();
            PropertyInfoDataType2 = new HashSet<PropertyInfo>();
            PropertyInfoDataType3 = new HashSet<PropertyInfo>();
            PropertyInfoDataType4 = new HashSet<PropertyInfo>();
        }

        public int DataTypeId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string DataType1 { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<PropertyInfo> PropertyInfoDataType1 { get; set; }
        public virtual ICollection<PropertyInfo> PropertyInfoDataType2 { get; set; }
        public virtual ICollection<PropertyInfo> PropertyInfoDataType3 { get; set; }
        public virtual ICollection<PropertyInfo> PropertyInfoDataType4 { get; set; }
    }
}
