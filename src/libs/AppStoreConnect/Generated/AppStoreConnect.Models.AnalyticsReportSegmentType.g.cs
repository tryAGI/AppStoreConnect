
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsReportSegmentType
    {
        /// <summary>
        ///
        /// </summary>
        AnalyticsReportSegments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportSegmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportSegmentType value)
        {
            return value switch
            {
                AnalyticsReportSegmentType.AnalyticsReportSegments => "analyticsReportSegments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportSegmentType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsReportSegments" => AnalyticsReportSegmentType.AnalyticsReportSegments,
                _ => null,
            };
        }
    }
}