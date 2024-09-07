using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class DocusignEnvelopeSatusTemp
    {
        public int Id { get; set; }
        public string EnvelopeId { get; set; } = null!;
        public string? RecepientId { get; set; }
        public bool? Status { get; set; }

        public virtual DocusignEnvelopesTemp Envelope { get; set; } = null!;
    }
}
