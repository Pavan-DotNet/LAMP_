using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeStocking
    {
        public string PosItemNumber { get; set; } = null!;
        public string PosItemCreatedDate { get; set; } = null!;
        public string PosClaimStatus { get; set; } = null!;
        public string PosCiStatus { get; set; } = null!;
        public string PosSoNumber { get; set; } = null!;
        public string PosDistiSales { get; set; } = null!;
        public string PosSerialNumber { get; set; } = null!;
        public string PosTransmissionNumber { get; set; } = null!;
        public string PosSdContractNumber { get; set; } = null!;
        public string PosEndCustKey { get; set; } = null!;
        public string PosEndCustName { get; set; } = null!;
        public string PosEndCustCountryCode { get; set; } = null!;
        public string SameEndCustomerInADifferentCountry { get; set; } = null!;
        public string PosEndCustCountry { get; set; } = null!;
        public string PosChannelPartnerKey { get; set; } = null!;
        public string PosDistiKey { get; set; } = null!;
        public string PosDistiName { get; set; } = null!;
        public string PosDistiCountry { get; set; } = null!;
        public string PosResellerKey { get; set; } = null!;
        public string PosResellerName { get; set; } = null!;
        public string PosResellerCountry { get; set; } = null!;
        public string PosDocOrderNumber { get; set; } = null!;
        public string PosMaterialKey { get; set; } = null!;
        public string PosMaterial { get; set; } = null!;
        public string PosMaterialProductCat { get; set; } = null!;
        public string PosMaterialTypeKey { get; set; } = null!;
        public string PosMaterialType { get; set; } = null!;
        public string PosTransactionQty { get; set; } = null!;
        public string PosReportedQty { get; set; } = null!;
        public string ListPrice { get; set; } = null!;
        public string PosJnprPosValue { get; set; } = null!;
        public string PosClaimAmt { get; set; } = null!;
        public string SvcContractNumber { get; set; } = null!;
        public string SvcContractType { get; set; } = null!;
        public int SvcContractItemNo { get; set; }
        public DateTime SvcContractCreationDate { get; set; }
        public string SvcContractStatus { get; set; } = null!;
        public string SvcServiceStartDate { get; set; } = null!;
        public string SvcServiceEndDate { get; set; } = null!;
        public string SvcSalesOrderAlpha { get; set; } = null!;
        public string SvcEndCustKey { get; set; } = null!;
        public string SvcEndCustName { get; set; } = null!;
        public string SvcEndCustCountryCode { get; set; } = null!;
        public string SvcMaterialKey { get; set; } = null!;
        public string SvcMaterial { get; set; } = null!;
        public string SvcServiceMaterialKey { get; set; } = null!;
        public string SvcServiceMaterial { get; set; } = null!;
        public string SvcServiceMaterialProductLine { get; set; } = null!;
        public string SvcProductLine { get; set; } = null!;
        public string SvcProductFamily { get; set; } = null!;
        public string SvcMaterialEccn { get; set; } = null!;
        public string SvcMaterialHts { get; set; } = null!;
        public string SvcSerialNumber { get; set; } = null!;
        public string SvcContractLineItemStatus { get; set; } = null!;
    }
}
