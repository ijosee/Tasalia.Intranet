using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class UseType
    {
        public UseType()
        {
            AppendantInfo = new HashSet<AppendantInfo>();
        }

        public int UseTypeId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string UseType1 { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppendantInfo> AppendantInfo { get; set; }
    }
}
