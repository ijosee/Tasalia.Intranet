using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class MaterialType
    {
        public MaterialType()
        {
            MaterialAppraisal = new HashSet<MaterialAppraisal>();
        }

        public int MaterialTypeId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<MaterialAppraisal> MaterialAppraisal { get; set; }
    }
}
