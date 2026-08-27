
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsReportRequestReportsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsReports,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportRequestReportsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportRequestReportsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AnalyticsReportRequestReportsLinkagesResponseDataItemType.AnalyticsReports => "analyticsReports",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportRequestReportsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsReports" => AnalyticsReportRequestReportsLinkagesResponseDataItemType.AnalyticsReports,
                _ => null,
            };
        }
    }
}