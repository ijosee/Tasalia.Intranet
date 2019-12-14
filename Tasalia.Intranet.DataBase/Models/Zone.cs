using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class Zone
    {
        public Zone()
        {
            PropertyInfo = new HashSet<PropertyInfo>();
        }

        public int ZoneId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string Zone1 { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<PropertyInfo> PropertyInfo { get; set; }
    }
}
