using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class State
    {
        public State()
        {
            City = new HashSet<City>();
        }

        public int StateId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string State1 { get; set; }
        public string Code { get; set; }
        public int? CountryId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<City> City { get; set; }
    }
}
