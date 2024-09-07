using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class Export
    {
        public string? UserId { get; set; }
        public string? Email { get; set; }
        public string? UserType { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CompanyName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Status { get; set; }
        public string? CreatedDate { get; set; }
        public string? CountryCode { get; set; }
        public string? SubStatus { get; set; }
        public string? RolesEntitled { get; set; }
        public string? SapBpid { get; set; }
        public string? SapAcctid { get; set; }
        public string? SapOrgid { get; set; }
        public string? SapOrgName { get; set; }
        public string? Entid { get; set; }
        public string? ContactStatus { get; set; }
        public string? AccountStatus { get; set; }
        public string? SapAcctName { get; set; }
        public string? PublicDomainFlg { get; set; }
        public string? ConcernedParty { get; set; }
    }
}
