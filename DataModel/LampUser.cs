using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class LampUser
    {
        public int Id { get; set; }
        public string? Userid { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Department { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Note { get; set; }
    }
}
