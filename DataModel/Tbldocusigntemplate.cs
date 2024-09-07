using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class Tbldocusigntemplate
    {
        public int Id { get; set; }
        public string TemplateId { get; set; } = null!;
        public string? TemplateName { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedById { get; set; }
        public string? DateCreated { get; set; }
        public string? LastModified { get; set; }
    }
}
