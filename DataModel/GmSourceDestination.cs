using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmSourceDestination
    {
        public int? Id { get; set; }
        public int? PathId { get; set; }
        public int? OrderOfPoints { get; set; }
        public string? SourceCountryCode { get; set; }
        public string? SourceCountryName { get; set; }
        public string? DestinationCountryCode { get; set; }
        public string? DestinationCountryName { get; set; }
        public int? DestinationCnt { get; set; }
    }
}
