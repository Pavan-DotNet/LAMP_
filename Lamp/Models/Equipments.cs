using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lamp.Models
{
    public class Equipments
    {
        public string HardwareSku { get; set; }
        public string JunousImage { get; set; }
        public string ProductSerial { get; set; }
        public string PurchOrder { get; set; }
        public string Permit { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public string PermitApplicant { get; set; }
        public string NamedPurchaser { get; set; }
    }
}
