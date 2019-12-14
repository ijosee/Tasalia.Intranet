using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class StreetType
    {
        public StreetType()
        {
            PropertyInfo = new HashSet<PropertyInfo>();
        }

        public int StreetTypeId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string StreetType1 { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<PropertyInfo> PropertyInfo { get; set; }
    }
}
