using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class UseState
    {
        public UseState()
        {
            AppendantInfo = new HashSet<AppendantInfo>();
        }

        public int UseStateId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string UseState1 { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppendantInfo> AppendantInfo { get; set; }
    }
}
