using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class MakingQuality
    {
        public MakingQuality()
        {
            AppendantInfo = new HashSet<AppendantInfo>();
        }

        public int MakingQualityId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string MakingQuality1 { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppendantInfo> AppendantInfo { get; set; }
    }
}
