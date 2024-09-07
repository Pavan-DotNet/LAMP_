using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class JobQueue
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public string Queue { get; set; } = null!;
        public DateTime? FetchedAt { get; set; }
    }
}
