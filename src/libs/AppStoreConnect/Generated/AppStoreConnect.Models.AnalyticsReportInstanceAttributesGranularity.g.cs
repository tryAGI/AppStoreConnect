
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsReportInstanceAttributesGranularity
    {
        /// <summary>
        ///
        /// </summary>
        Daily,
        /// <summary>
        ///
        /// </summary>
        Monthly,
        /// <summary>
        ///
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportInstanceAttributesGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportInstanceAttributesGranularity value)
        {
            return value switch
            {
                AnalyticsReportInstanceAttributesGranularity.Daily => "DAILY",
                AnalyticsReportInstanceAttributesGranularity.Monthly => "MONTHLY",
                AnalyticsReportInstanceAttributesGranularity.Weekly => "WEEKLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportInstanceAttributesGranularity? ToEnum(string value)
        {
            return value switch
            {
                "DAILY" => AnalyticsReportInstanceAttributesGranularity.Daily,
                "MONTHLY" => AnalyticsReportInstanceAttributesGranularity.Monthly,
                "WEEKLY" => AnalyticsReportInstanceAttributesGranularity.Weekly,
                _ => null,
            };
        }
    }
}