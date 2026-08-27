
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAnalyticsReportRequestsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsReportRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAnalyticsReportRequestsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAnalyticsReportRequestsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppAnalyticsReportRequestsLinkagesResponseDataItemType.AnalyticsReportRequests => "analyticsReportRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAnalyticsReportRequestsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsReportRequests" => AppAnalyticsReportRequestsLinkagesResponseDataItemType.AnalyticsReportRequests,
                _ => null,
            };
        }
    }
}