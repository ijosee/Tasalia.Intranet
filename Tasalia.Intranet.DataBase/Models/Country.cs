using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class Country
    {
        public Country()
        {
            State = new HashSet<State>();
        }

        public int CountryId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string Country1 { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<State> State { get; set; }
    }
}
