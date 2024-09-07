using System.ComponentModel;

namespace Lamp.Models
{
    public class TapPolicy
    {
        public int Id { get; set; }
        public string Policy_RequestType { get; set; }
        public string Biennial_Review { get; set; }
        public string Requester_Name { get; set; }
        public string Requester_Email { get; set; }
        public string NewPolicy_TriggeringEvent { get; set; }
        public string NewPolicy_TriggeringEvent_Other { get; set; }
        public string UpdatePolicy_TriggeringEvent { get; set; }
        public string UpdatePolicy_TriggeringEvent_Other { get; set; }
        public string ExistingPolicy_EndWorkflow { get; set; }
        public string NewPolicy_Document { get; set; }
        public string ExistingPolicy_Requested { get; set; }
        public string UpdatePolicy_SelectPolicy { get; set; }
        public string UpdatedPolicy_Document { get; set; }
        public string Function { get; set; }
        public string Policy_name { get; set; }
        public string Policy_owner { get; set; }
        public string Policy_sponsor { get; set; }
        public string Policy_effectivedate { get; set; }
        public string RetirePolicy_Reasons { get; set; }
        public string Policy_FinalVersion { get; set; }
        public string CCOApproval { get; set; }
        public string ICGConfirmation { get; set; }
        public string ReasonsForRejecting { get; set; }
        public string BiennialReview_Last { get; set; }
        public string Other_rejection { get; set; }
        public string Is_Active { get; set; } = "1";
    }
}
