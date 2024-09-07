using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeKpiDashTwb
    {
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public int? PShpSoCnt { get; set; }
        public int? PShpSnCnt { get; set; }
        public int? PShpSnWithSvc { get; set; }
        public int? PShpSvcEligibleCnt { get; set; }
        public decimal? PSvcAttachedRate { get; set; }
        public int? PDivCnt { get; set; }
        public decimal? PDivRate { get; set; }
        public decimal? PShpListAmt { get; set; }
        public decimal? PShpNetAmt { get; set; }
        public string? PResellerAddress { get; set; }
        public string? PResellerCountryCode { get; set; }
        public string? PResellerCountryName { get; set; }
        public string? PResellerTheater { get; set; }
        public DateTime? PCustomersince { get; set; }
        public string? PPartnerLevel { get; set; }
        public string? PPartnerStatus { get; set; }
        public string? ChannelModel { get; set; }
        public string? DiversionType { get; set; }
        public int? DrspPosId { get; set; }
        public string? SourceTransaction { get; set; }
        public string? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? TrnxFiscalQtr { get; set; }
        public string? CustomerGroup { get; set; }
        public string? PoType { get; set; }
        public string? SoNumber { get; set; }
        public string? SerialNumber { get; set; }
        public string? MaterialKey { get; set; }
        public string? MaterialDesc { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? DiscPerc { get; set; }
        public string? EndCustKey { get; set; }
        public string? EndCustName { get; set; }
        public string? EndCustCountryCode { get; set; }
        public string? EndCustCountry { get; set; }
        public string? EndCustTheater { get; set; }
        public string? BilltoKey { get; set; }
        public string? BilltoName { get; set; }
        public string? BilltoCountryCode { get; set; }
        public string? BilltoCountryName { get; set; }
        public string? DistiKey { get; set; }
        public string? DistiName { get; set; }
        public string? DistiCountryCode { get; set; }
        public string? DistiCountryName { get; set; }
        public string? DistiTheater { get; set; }
        public string? SoldtoKey { get; set; }
        public string? SoldtoName { get; set; }
        public string? SoldtoCountryCode { get; set; }
        public string? SoldtoCountryName { get; set; }
        public string? ShiptoKey { get; set; }
        public string? ShiptoCustomer { get; set; }
        public string? ShiptoCountryCode { get; set; }
        public string? ShiptoCountryName { get; set; }
        public string? AccountManager { get; set; }
        public string? AmCountryCode { get; set; }
        public string? AmCountryName { get; set; }
        public string? AmTheater { get; set; }
        public string? SvcContractNumber { get; set; }
        public string? SvcContractLineStatus { get; set; }
        public string? SvcSalesOrder { get; set; }
        public string? SvcMaterialKey { get; set; }
        public decimal? SvcNetValue { get; set; }
        public string? SvcInstalledAtKey { get; set; }
        public string? SvcInstalledAtName { get; set; }
        public string? SvcEndCustKey { get; set; }
        public string? SvcEndCustName { get; set; }
        public string? SvcEndCustCountryCode { get; set; }
        public string? SvcEndCustCountryName { get; set; }
        public string? SvcEndCustTheater { get; set; }
        public string? SvcBilltoKey { get; set; }
        public string? SvcBilltoName { get; set; }
        public string? SvcBilltoCountryCode { get; set; }
        public string? QuoteId { get; set; }
        public string? RmaNumber { get; set; }
        public int? GlobalAcctScore { get; set; }
        public int? MspAcctScore { get; set; }
        public string? GmeFlag { get; set; }
        public string TargetFlag { get; set; } = null!;
        public string? SvcEligibleFlag { get; set; }
    }
}
