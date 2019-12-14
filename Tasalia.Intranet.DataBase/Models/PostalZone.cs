using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class PostalZone
    {
        public PostalZone()
        {
            Property = new HashSet<Property>();
        }

        public int PostalZoneId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string PostalZone1 { get; set; }
        public string ZipCode { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<Property> Property { get; set; }
    }
}
