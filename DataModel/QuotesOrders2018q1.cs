using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class QuotesOrders2018q1
    {
        public string QuoteId { get; set; } = null!;
        public string QuoteCreatedWeek { get; set; } = null!;
        public string QuoteCreatedMonth { get; set; } = null!;
        public string QuoteCreatedYear { get; set; } = null!;
        public string OrderCreatedWeek { get; set; } = null!;
        public string OrderCreatedMonth { get; set; } = null!;
        public string OrderCreatedYear { get; set; } = null!;
        public string QuoteType { get; set; } = null!;
        public string QuoteItemNo { get; set; } = null!;
        public string QuoteItemTransactionType { get; set; } = null!;
        public string OrderId { get; set; } = null!;
        public string OrderType { get; set; } = null!;
        public string OrderItemNo { get; set; } = null!;
        public string OrderItemTransactionType { get; set; } = null!;
        public string QuoteTotalGross { get; set; } = null!;
        public string QuoteNetValueOfItem { get; set; } = null!;
        public string QuoteTotalFreight { get; set; } = null!;
        public string QuoteFmvActual { get; set; } = null!;
        public string QuoteAllocatedRevenue { get; set; } = null!;
        public string QuoteTotalDerivedL0Discount { get; set; } = null!;
        public string OrderTotalGross { get; set; } = null!;
        public string OrderNetValueOfItem { get; set; } = null!;
        public string OrderTotalFreight { get; set; } = null!;
        public string OrderFmvActual { get; set; } = null!;
        public string OrderAllocatedRevenue { get; set; } = null!;
        public string OrderTotalDerivedL0Discount { get; set; } = null!;
    }
}
