
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsReportSegmentsGetInstanceFieldsAnalyticsReportSegment
    {
        /// <summary>
        ///
        /// </summary>
        Checksum,
        /// <summary>
        ///
        /// </summary>
        SizeInBytes,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportSegmentsGetInstanceFieldsAnalyticsReportSegmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportSegmentsGetInstanceFieldsAnalyticsReportSegment value)
        {
            return value switch
            {
                AnalyticsReportSegmentsGetInstanceFieldsAnalyticsReportSegment.Checksum => "checksum",
                AnalyticsReportSegmentsGetInstanceFieldsAnalyticsReportSegment.SizeInBytes => "sizeInBytes",
                AnalyticsReportSegmentsGetInstanceFieldsAnalyticsReportSegment.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportSegmentsGetInstanceFieldsAnalyticsReportSegment? ToEnum(string value)
        {
            return value switch
            {
                "checksum" => AnalyticsReportSegmentsGetInstanceFieldsAnalyticsReportSegment.Checksum,
                "sizeInBytes" => AnalyticsReportSegmentsGetInstanceFieldsAnalyticsReportSegment.SizeInBytes,
                "url" => AnalyticsReportSegmentsGetInstanceFieldsAnalyticsReportSegment.Url,
                _ => null,
            };
        }
    }
}