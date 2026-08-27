
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment
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
    public static class AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment value)
        {
            return value switch
            {
                AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment.Checksum => "checksum",
                AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment.SizeInBytes => "sizeInBytes",
                AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment? ToEnum(string value)
        {
            return value switch
            {
                "checksum" => AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment.Checksum,
                "sizeInBytes" => AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment.SizeInBytes,
                "url" => AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment.Url,
                _ => null,
            };
        }
    }
}