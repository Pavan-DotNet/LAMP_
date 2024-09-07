using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class UserRoleMapping
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
