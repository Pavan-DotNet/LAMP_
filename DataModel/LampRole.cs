using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class LampRole
    {
        public int Id { get; set; }
        public string? Role { get; set; }
        public string? RoleType { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Note { get; set; }
    }
}
