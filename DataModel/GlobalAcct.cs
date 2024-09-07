using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GlobalAcct
    {
        public int? Id { get; set; }
        public string? EntityKey { get; set; }
        public string? Theater { get; set; }
        public string? Parent { get; set; }
        public string? Group { get; set; }
        public string? GMnDesignation { get; set; }
        public string? ParentAcctVertical { get; set; }
        public string? GlobalAcctManager { get; set; }
        public string? GamUserid { get; set; }
        public string? FyList { get; set; }
        public string? AltParent { get; set; }
        public string? AltGroup { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Status { get; set; }
    }
}
