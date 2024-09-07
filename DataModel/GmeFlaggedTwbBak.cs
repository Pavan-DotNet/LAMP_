using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeFlaggedTwbBak
    {
        public int? ShpSnCnt { get; set; }
        public int? ShpSnWithSvc { get; set; }
        public decimal? ShpListAmt { get; set; }
        public decimal? ShpNetAmt { get; set; }
        public int? ShpSvcEligibleCnt { get; set; }
        public decimal? PSvcAttachedRate { get; set; }
        public string? ChannelModel { get; set; }
        public string DiversionType { get; set; } = null!;
        public int DrspPosId { get; set; }
        public string? SourceTransaction { get; set; }
        public int? SourceImportId { get; set; }
        public string? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? DeliveryItem { get; set; }
        public string? TransactionType { get; set; }
        public string? CustomerGroup { get; set; }
        public string PoType { get; set; } = null!;
        public string? SoNumber { get; set; }
        public string? SoNumberOrig { get; set; }
        public int? SoItem { get; set; }
        public string? SoType { get; set; }
        public DateTime? SoDate { get; set; }
        public string? SerialNumber { get; set; }
        public string? SerialNumberOrig { get; set; }
        public string? MaterialKey { get; set; }
        public string? MaterialDesc { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? DiscPerc { get; set; }
        public string? EndCustKey { get; set; }
        public string? EndCustName { get; set; }
        public string? EndCustAddress { get; set; }
        public string? EndCustCountryCode { get; set; }
        public string? EndCustCountry { get; set; }
        public string? EndCustTheater { get; set; }
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public string? ResellerAddress { get; set; }
        public string? ResellerCountryCode { get; set; }
        public string? ResellerCountry { get; set; }
        public string? ResellerTheater { get; set; }
        public string? BilltoKey { get; set; }
        public string? BilltoName { get; set; }
        public string? BilltoAddress { get; set; }
        public string? BilltoCountryCode { get; set; }
        public string? BilltoCountryName { get; set; }
        public string? DistiKey { get; set; }
        public string? DistiName { get; set; }
        public string? DistiAddress { get; set; }
        public string? DistiCountryCode { get; set; }
        public string? DistiCountryName { get; set; }
        public string? DistiTheater { get; set; }
        public string SoldtoKey { get; set; } = null!;
        public string? SoldtoName { get; set; }
        public string? SoldtoAddress { get; set; }
        public string? SoldtoCountryCode { get; set; }
        public string? SoldtoCountryName { get; set; }
        public string ShiptoKey { get; set; } = null!;
        public string? ShiptoCustomer { get; set; }
        public string? ShiptoAddress { get; set; }
        public string? ShiptoCountryCode { get; set; }
        public string? ShiptoCountryName { get; set; }
        public string? ClaimStatus { get; set; }
        public string? CiStatus { get; set; }
        public string? AccountManager { get; set; }
        public string? AmCountryCode { get; set; }
        public string? AmCountryName { get; set; }
        public string? AmTheater { get; set; }
        public string? SvcContractNumber { get; set; }
        public DateTime? SvcContractCreationDate { get; set; }
        public string? SvcContractType { get; set; }
        public string? SvcContractStatus { get; set; }
        public DateTime? SvcStartDate { get; set; }
        public DateTime? SvcEndDate { get; set; }
        public string? SvcContractLineStatus { get; set; }
        public DateTime? SvcContractLineCreation { get; set; }
        public string? SvcSalesOrder { get; set; }
        public string? SvcMaterialKey { get; set; }
        public string? SvcMaterialDesc { get; set; }
        public decimal? SvcListValue { get; set; }
        public decimal? SvcNetValue { get; set; }
        public string? SvcCurrency { get; set; }
        public string? SvcInstalledAtKey { get; set; }
        public string? SvcInstalledAtName { get; set; }
        public string? SvcInstalledAtDistrict { get; set; }
        public string? SvcInstalledAtCountryCode { get; set; }
        public string? SvcInstalledAtCountryName { get; set; }
        public string? SvcEndCustKey { get; set; }
        public string? SvcEndCustName { get; set; }
        public string? SvcEndCustCity { get; set; }
        public string? SvcEndCustCountryCode { get; set; }
        public string? SvcEndCustCountryName { get; set; }
        public string? SvcEndCustTheater { get; set; }
        public string? SvcPayerKey { get; set; }
        public string? SvcPayerName { get; set; }
        public string? SvcPayerCountry { get; set; }
        public string? SvcBilltoKey { get; set; }
        public string? SvcBilltoName { get; set; }
        public string? SvcBilltoCountryCode { get; set; }
        public string? RmaNumber { get; set; }
        public string? QuoteId { get; set; }
        public string? EcSvcKeyFlag { get; set; }
        public string? ResEcKeyFlag { get; set; }
        public double? EcSvcJaroScore { get; set; }
        public double? ResEcJaroScore { get; set; }
        public int? GlobalAcctScore { get; set; }
        public string? EntityExceptionFlag { get; set; }
        public int EcSvcSenzingScore { get; set; }
        public int? MspAcctScore { get; set; }
        public string? GmeFlag { get; set; }
        public DateTime? CreateDate { get; set; }
        public string TargetFlag { get; set; } = null!;
        public int PartnerOldNew { get; set; }
        public int SoOldNew { get; set; }
        public int SnOldNew { get; set; }
        public int? PartnerDeltaSum { get; set; }
        public int? SoDeltaSum { get; set; }
        public string PartnerDelta { get; set; } = null!;
        public string SoDelta { get; set; } = null!;
        public string SnDelta { get; set; } = null!;
        public int? SnShippedCntPso { get; set; }
        public decimal? ListAmtPso { get; set; }
        public decimal? NetAmtPso { get; set; }
        public int? SnWithSvcPso { get; set; }
        public decimal? ListAmtWithSvcPso { get; set; }
        public decimal? NetAmtWithSvcPso { get; set; }
    }
}
