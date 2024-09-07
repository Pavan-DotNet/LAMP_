using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeEntityException
    {
        public int Id { get; set; }
        public string? Key1 { get; set; }
        public string? Key2 { get; set; }
        public string? Key3 { get; set; }
        public string? Attribute1 { get; set; }
        public string? Attribute2 { get; set; }
        public string? Attribute3 { get; set; }
        public string? Attribute4 { get; set; }
        public string? Attribute5 { get; set; }
        public int? Attribute6 { get; set; }
        public string? Notes { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
