using System;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class Process
    {
        public Guid Guid { get; set; }
        public DateTime Time { get; set; }
        public string Name { get; set; }
    }
}
