using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class EstateType
    {
        public EstateType()
        {
            AppendantInfo = new HashSet<AppendantInfo>();
        }

        public int EstateTypeId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string EstateType1 { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppendantInfo> AppendantInfo { get; set; }
    }
}
