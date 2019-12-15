using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class HouseZone
    {
        public HouseZone()
        {
            MaterialAppraisal = new HashSet<MaterialAppraisal>();
        }

        public int HouseZoneId { get; set; }
        public string HouseZone1 { get; set; }
        public string Pattern { get; set; }

        public virtual ICollection<MaterialAppraisal> MaterialAppraisal { get; set; }
    }
}
