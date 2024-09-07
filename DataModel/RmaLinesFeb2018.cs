using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class RmaLinesFeb2018
    {
        public string ComplaintsNo { get; set; } = null!;
        public string RmaItemNumber0crmNumint { get; set; } = null!;
        public string HeaderStatus { get; set; } = null!;
        public string ItemStatus { get; set; } = null!;
        public string? RmaCreateDate { get; set; }
        public string? ItemCreateDate { get; set; }
        public string ValuationType { get; set; } = null!;
        public string RmaItemType { get; set; } = null!;
        public string RmaItemTypeKey { get; set; } = null!;
        public string ServiceReqNo { get; set; } = null!;
        public string DefectSerialNo { get; set; } = null!;
        public string DefectProductIdKey { get; set; } = null!;
        public string DefectProductId { get; set; } = null!;
        public string DefectProductIdEccnKey { get; set; } = null!;
        public string DefectProductIdHtsKey { get; set; } = null!;
        public string DefectProductIdOverLengthPartNumKey { get; set; } = null!;
        public string ReplaceSerialNo { get; set; } = null!;
        public string ReplaceProductId0materialKey { get; set; } = null!;
        public string ReplaceProductId0material { get; set; } = null!;
        public string ReplaceEccn { get; set; } = null!;
        public string ReplaceProductId0materialHtsKey { get; set; } = null!;
        public string ReplaceProductId0materialOverLengthPartNumKey { get; set; } = null!;
        public string PlantKey { get; set; } = null!;
        public string PlantText { get; set; } = null!;
        public string StorageLocationKey { get; set; } = null!;
        public string StorageLocationText { get; set; } = null!;
        public string EndCustomerKey { get; set; } = null!;
        public string EndCustomerName { get; set; } = null!;
        public string EndCustomerBasStreetKey { get; set; } = null!;
        public string EndCustomerBasStreet2Key { get; set; } = null!;
        public string EndCustomerBasStreet3Key { get; set; } = null!;
        public string EndCustomerBasStreet4Key { get; set; } = null!;
        public string EndCustomerCity { get; set; } = null!;
        public string EndCustomerRegionText { get; set; } = null!;
        public string EndCustomerCountryKey { get; set; } = null!;
        public string EndCustomerCountryText { get; set; } = null!;
        public string EndCustomerBasPostalCodeKey { get; set; } = null!;
        public string AssociatedContactKey { get; set; } = null!;
        public string AssociatedContactName { get; set; } = null!;
        public string AssociatedContactBasStreetKey { get; set; } = null!;
        public string AssociatedContactBasStreet2Key { get; set; } = null!;
        public string AssociatedContactBasStreet3Key { get; set; } = null!;
        public string AssociatedContactBasStreet4Key { get; set; } = null!;
        public string AssociatedContactCity { get; set; } = null!;
        public string AssociatedContactRegionText { get; set; } = null!;
        public string AssociatedContactCountryKey { get; set; } = null!;
        public string AssociatedContactCountryText { get; set; } = null!;
        public string AssociatedContactBasPostalCodeKey { get; set; } = null!;
        public string? ShipDate { get; set; }
        public string TrackingNo { get; set; } = null!;
        public string ShipToSiteKey { get; set; } = null!;
        public string ShipToSiteName { get; set; } = null!;
        public string ShipToAddr1Key { get; set; } = null!;
        public string ShipToAddr2Key { get; set; } = null!;
        public string ShipToCityKey { get; set; } = null!;
        public string ShipToSiteRegionKey { get; set; } = null!;
        public string ShipToSiteRegion { get; set; } = null!;
        public string ShipToSiteCountryKey { get; set; } = null!;
        public string ShipToSitePostalCodeKey { get; set; } = null!;
        public string InstalledAtKey { get; set; } = null!;
        public string InstalledAtName { get; set; } = null!;
        public string InstalledAtBasStreetKey { get; set; } = null!;
        public string InstalledAtBasStreet2Key { get; set; } = null!;
        public string InstalledAtBasStreet3Key { get; set; } = null!;
        public string InstalledAtBasStreet4Key { get; set; } = null!;
        public string InstalledAtCity { get; set; } = null!;
        public string InstalledAtRegionText { get; set; } = null!;
        public string InstalledAtCountryKey { get; set; } = null!;
        public string InstalledAtCountryText { get; set; } = null!;
        public string InstalledAtBasPostalCodeKey { get; set; } = null!;
        public string CustomsDeclarationNo { get; set; } = null!;
        public string? CustomsDeclCreateDt { get; set; }
        public string Coo { get; set; } = null!;
        public string DeliveryNumber { get; set; } = null!;
        public string? DeliveryCreateDate { get; set; }
        public string LegalRegulation { get; set; } = null!;
        public string? LicenseValidFrom { get; set; }
        public string? LicenseValidTo { get; set; }
        public string? LicenseAppliedDate { get; set; }
        public string LicenseNumber { get; set; } = null!;
        public string LicenseType { get; set; } = null!;
        public string ExtLicence { get; set; } = null!;
        public string GoodsSupplier { get; set; } = null!;
        public string GoodsSupplierKey { get; set; } = null!;
        public string Vendor { get; set; } = null!;
        public string VendorKey { get; set; } = null!;
        public string ShipToPartyKey { get; set; } = null!;
        public string GtsShipToKey { get; set; } = null!;
        public string GtsShipToAddressKey { get; set; } = null!;
        public string GtsShipToAddr1Key { get; set; } = null!;
        public string GtsShipToAddr2Key { get; set; } = null!;
        public string GtsShipToCity { get; set; } = null!;
        public string GtsShipToCountry { get; set; } = null!;
        public string BillToPartyKey { get; set; } = null!;
        public string GtsBillToKey { get; set; } = null!;
        public string GtsBillToAddressKey { get; set; } = null!;
        public string GtsBillToAddr1Key { get; set; } = null!;
        public string GtsBillToAddr2Key { get; set; } = null!;
        public string GtsBillToCity { get; set; } = null!;
        public string GtsBillToCountry { get; set; } = null!;
        public string ExporterKey { get; set; } = null!;
        public string GtsExporterAddressKey { get; set; } = null!;
        public string ExporterAddr1Key { get; set; } = null!;
        public string ExporterAddr2Key { get; set; } = null!;
        public string ExporterCity { get; set; } = null!;
        public string ExporterCountry { get; set; } = null!;
        public string CustomsValuation { get; set; } = null!;
    }
}
