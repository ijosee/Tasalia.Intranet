using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class City
    {
        public City()
        {
            Property = new HashSet<Property>();
        }

        public int CityId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string City1 { get; set; }
        public string Code { get; set; }
        public int? StateId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<Property> Property { get; set; }
    }
}
