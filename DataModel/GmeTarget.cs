using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeTarget
    {
        public int Id { get; set; }
        public string? EntityKey { get; set; }
        public string? EntityName { get; set; }
        public string? EntityType { get; set; }
        public string? CountryCode { get; set; }
        public string? Theater { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CountryName { get; set; }
        public DateTime? DateOpened { get; set; }
        public DateTime? DateComplete { get; set; }
        public string? Remediation { get; set; }
        public string? RemediationStatus { get; set; }
        public string? Notes { get; set; }
        public string? EmailSent { get; set; }
        public string? EmailForm { get; set; }
        public string? Website { get; set; }
        public decimal? DealSize { get; set; }
        public string? WinFlag { get; set; }
        public string? SfdcId { get; set; }
        public string? VarId { get; set; }
        public string? EntityLevel { get; set; }
        public string? NsNotes { get; set; }
        public decimal? Recoveries { get; set; }
    }
}
