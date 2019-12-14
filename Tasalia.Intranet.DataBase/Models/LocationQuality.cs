using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class LocationQuality
    {
        public LocationQuality()
        {
            AppendantInfo = new HashSet<AppendantInfo>();
        }

        public int LocationQualityId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string LocationQuality1 { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppendantInfo> AppendantInfo { get; set; }
    }
}
