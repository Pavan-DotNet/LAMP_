using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class TblConsigneeUndertaking
    {
        public int Id { get; set; }
        public string EnvelopeId { get; set; } = null!;
        public string? TemplateId { get; set; }
        public string? Email { get; set; }
        public string? CompanyName { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        public string? SignerEmail { get; set; }
        public string? DateSigned { get; set; }
        public byte[]? Document { get; set; }
        public string? WebSite { get; set; }
        public string? JobTitle { get; set; }
        public string? Street { get; set; }
        public byte[]? Document2 { get; set; }
    }
}
