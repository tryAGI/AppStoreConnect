
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsReportInstanceSegmentsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsReportSegments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportInstanceSegmentsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportInstanceSegmentsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AnalyticsReportInstanceSegmentsLinkagesResponseDataItemType.AnalyticsReportSegments => "analyticsReportSegments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportInstanceSegmentsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsReportSegments" => AnalyticsReportInstanceSegmentsLinkagesResponseDataItemType.AnalyticsReportSegments,
                _ => null,
            };
        }
    }
}