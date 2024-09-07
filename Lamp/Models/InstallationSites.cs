using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lamp.Models
{
    public class InstallationSites
    {
        public string Inst_Addresss { get; set; }
        public string Inst_Province { get; set; }
        public string Inst_Postal { get; set; }
        public string Inst_Country { get; set; }
        public List<Equipments> Equipments { get; set; }
    }
}
