using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class LampEtlLog
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Process { get; set; }
        public string? ProgramExec { get; set; }
        public string? Status { get; set; }
        public int? RecordCnt { get; set; }
        public string? Message { get; set; }
    }
}
