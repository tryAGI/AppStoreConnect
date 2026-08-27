
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SalesReportsGetCollectionFilterReportTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        FirstAnnual,
        /// <summary>
        ///
        /// </summary>
        Installs,
        /// <summary>
        ///
        /// </summary>
        Newsstand,
        /// <summary>
        ///
        /// </summary>
        PreOrder,
        /// <summary>
        ///
        /// </summary>
        Sales,
        /// <summary>
        ///
        /// </summary>
        Subscriber,
        /// <summary>
        ///
        /// </summary>
        Subscription,
        /// <summary>
        ///
        /// </summary>
        SubscriptionEvent,
        /// <summary>
        ///
        /// </summary>
        SubscriptionOfferCodeRedemption,
        /// <summary>
        ///
        /// </summary>
        WinBackEligibility,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SalesReportsGetCollectionFilterReportTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SalesReportsGetCollectionFilterReportTypeItem value)
        {
            return value switch
            {
                SalesReportsGetCollectionFilterReportTypeItem.FirstAnnual => "FIRST_ANNUAL",
                SalesReportsGetCollectionFilterReportTypeItem.Installs => "INSTALLS",
                SalesReportsGetCollectionFilterReportTypeItem.Newsstand => "NEWSSTAND",
                SalesReportsGetCollectionFilterReportTypeItem.PreOrder => "PRE_ORDER",
                SalesReportsGetCollectionFilterReportTypeItem.Sales => "SALES",
                SalesReportsGetCollectionFilterReportTypeItem.Subscriber => "SUBSCRIBER",
                SalesReportsGetCollectionFilterReportTypeItem.Subscription => "SUBSCRIPTION",
                SalesReportsGetCollectionFilterReportTypeItem.SubscriptionEvent => "SUBSCRIPTION_EVENT",
                SalesReportsGetCollectionFilterReportTypeItem.SubscriptionOfferCodeRedemption => "SUBSCRIPTION_OFFER_CODE_REDEMPTION",
                SalesReportsGetCollectionFilterReportTypeItem.WinBackEligibility => "WIN_BACK_ELIGIBILITY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SalesReportsGetCollectionFilterReportTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "FIRST_ANNUAL" => SalesReportsGetCollectionFilterReportTypeItem.FirstAnnual,
                "INSTALLS" => SalesReportsGetCollectionFilterReportTypeItem.Installs,
                "NEWSSTAND" => SalesReportsGetCollectionFilterReportTypeItem.Newsstand,
                "PRE_ORDER" => SalesReportsGetCollectionFilterReportTypeItem.PreOrder,
                "SALES" => SalesReportsGetCollectionFilterReportTypeItem.Sales,
                "SUBSCRIBER" => SalesReportsGetCollectionFilterReportTypeItem.Subscriber,
                "SUBSCRIPTION" => SalesReportsGetCollectionFilterReportTypeItem.Subscription,
                "SUBSCRIPTION_EVENT" => SalesReportsGetCollectionFilterReportTypeItem.SubscriptionEvent,
                "SUBSCRIPTION_OFFER_CODE_REDEMPTION" => SalesReportsGetCollectionFilterReportTypeItem.SubscriptionOfferCodeRedemption,
                "WIN_BACK_ELIGIBILITY" => SalesReportsGetCollectionFilterReportTypeItem.WinBackEligibility,
                _ => null,
            };
        }
    }
}