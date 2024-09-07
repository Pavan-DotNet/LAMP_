using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class Job
    {
        public Job()
        {
            JobParameters = new HashSet<JobParameter>();
            States = new HashSet<State>();
        }

        public int Id { get; set; }
        public int? StateId { get; set; }
        public string? StateName { get; set; }
        public string InvocationData { get; set; } = null!;
        public string Arguments { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpireAt { get; set; }

        public virtual ICollection<JobParameter> JobParameters { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}
