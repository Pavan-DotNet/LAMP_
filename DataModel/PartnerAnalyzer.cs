using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class PartnerAnalyzer
    {
        public string? ResellerName { get; set; }
        public string? ResellerCountry { get; set; }
        public string? ResellerCountryCode { get; set; }
        public double? TotalNumberOfLinesReportedInJan2016May2017 { get; set; }
        public double? ValueOfAllProductsSold { get; set; }
        public double? NumberOfLinesWithServiceAttached { get; set; }
        public double? ServiceAttach { get; set; }
        public double? ValueOfProductsWithServiceAttached { get; set; }
        public double? NumberOfLinesSnsWithCountryMismatches { get; set; }
        public double? Diversion { get; set; }
        public double? ValueOfFlaggedDivertedProducts { get; set; }
        public double? ListPriceOfFlaggedDivertedProducts { get; set; }
        public double? DiscountForDivertedProducts { get; set; }
        public double? GreyMarketLossBasedOnStandardDiscountOf37 { get; set; }
        public double? GreyMarketLossBasedOnStandardDiscountOf371 { get; set; }
        public string? ChannelModel { get; set; }
    }
}
