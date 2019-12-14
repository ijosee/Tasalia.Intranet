using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class Currency
    {
        public Currency()
        {
            AppraisalInfo = new HashSet<AppraisalInfo>();
        }

        public int CurrencyId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string Currency1 { get; set; }
        public string Symbol { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<AppraisalInfo> AppraisalInfo { get; set; }
    }
}
