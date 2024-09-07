using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class PkTemp
    {
        public int Id { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public string? CarDescription { get; set; }
        public string? VehicelOverview { get; set; }
        public string? Year { get; set; }
        public int? Price { get; set; }
        public string? FuelType { get; set; }
        public string? TransmissionType { get; set; }
        public string? Mileage { get; set; }
        public string? Vin { get; set; }
        public string? StockNo { get; set; }
        public string? Feature { get; set; }
        public string? Photos { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
