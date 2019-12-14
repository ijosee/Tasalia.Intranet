using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class Property
    {
        public Property()
        {
            AppendantInfo = new HashSet<AppendantInfo>();
            Appraisal = new HashSet<Appraisal>();
            PropertyInfo = new HashSet<PropertyInfo>();
        }

        public int PropertyId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string ExternalId { get; set; }
        public string Year { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? PostalZoneId { get; set; }
        public int? CityId { get; set; }
        public int? FileTypeId { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        public virtual City City { get; set; }
        public virtual FileType FileType { get; set; }
        public virtual PostalZone PostalZone { get; set; }
        public virtual ICollection<AppendantInfo> AppendantInfo { get; set; }
        public virtual ICollection<Appraisal> Appraisal { get; set; }
        public virtual ICollection<PropertyInfo> PropertyInfo { get; set; }
    }
}
