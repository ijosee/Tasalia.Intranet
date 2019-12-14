using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class HeatingType
    {
        public HeatingType()
        {
            AppendantInfo = new HashSet<AppendantInfo>();
        }

        public int HeatingTypeId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string HeatingType1 { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppendantInfo> AppendantInfo { get; set; }
    }
}
