using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class FileType
    {
        public FileType()
        {
            Property = new HashSet<Property>();
        }

        public int FileTypeId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public string FileType1 { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<Property> Property { get; set; }
    }
}
