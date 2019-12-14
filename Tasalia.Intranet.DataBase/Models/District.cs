using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class District
    {
        public District()
        {
            PropertyInfo = new HashSet<PropertyInfo>();
        }

        public int DistrictId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string District1 { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<PropertyInfo> PropertyInfo { get; set; }
    }
}
