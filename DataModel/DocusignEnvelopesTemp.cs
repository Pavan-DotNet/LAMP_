using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class DocusignEnvelopesTemp
    {
        public DocusignEnvelopesTemp()
        {
            DocusignEnvelopeSatusTemps = new HashSet<DocusignEnvelopeSatusTemp>();
        }

        public int Id { get; set; }
        public string EnvelopeId { get; set; } = null!;
        public string? EnvelopeHeader { get; set; }

        public virtual ICollection<DocusignEnvelopeSatusTemp> DocusignEnvelopeSatusTemps { get; set; }
    }
}
