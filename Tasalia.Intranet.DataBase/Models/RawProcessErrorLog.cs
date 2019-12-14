using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class RawProcessErrorLog
    {
        public int RawProcessErrorLogId { get; set; }
        public int? RawId { get; set; }
        public Guid ProcessGuid { get; set; }
        public DateTime ProcessTime { get; set; }
        public int? SqlErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
