using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lamp.Models
{
    public class SwdlForm
    {
        public int? Id { get; set; }
        public string Cert_Comp_Name { get; set; }
        public string Cert_Address { get; set; }
        public string Cert_Phone_No { get; set; }
        public string Cert_Contact_Name { get; set; }
        public string Cert_Email_Notice { get; set; }
        public string Cert_Contact_Person_Email { get; set; }
        public string End_User_Name { get; set; }
        public string End_User_Address { get; set; }
        public string End_User_Website { get; set; }
        public string End_User_Phone { get; set; }
        public string End_User_Contact_Name { get; set; }
        public string End_User_Contact_Email { get; set; }
        public string Signature { get; set; }
        public DateTime? Dated { get; set; }
        public List<InstallationSites> Installation_Sites { get; set; }
        public DateTime? Created_Date { get; set; }
        public string View_Link { get; set; }
        public string ErrorDesc { get; set; }
    }
}
