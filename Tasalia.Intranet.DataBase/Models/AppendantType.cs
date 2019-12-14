using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class AppendantType
    {
        public AppendantType()
        {
            AppendantInfo = new HashSet<AppendantInfo>();
        }

        public int AppendantTypeId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string AppendantType1 { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppendantInfo> AppendantInfo { get; set; }
    }
}
