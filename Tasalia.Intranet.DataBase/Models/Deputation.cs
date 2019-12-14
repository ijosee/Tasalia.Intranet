using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class Deputation
    {
        public Deputation()
        {
            Appraisal = new HashSet<Appraisal>();
        }

        public int DeputationId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string Deputation1 { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<Appraisal> Appraisal { get; set; }
    }
}
