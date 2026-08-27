
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsReportInstanceType
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsReportInstances,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportInstanceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportInstanceType value)
        {
            return value switch
            {
                AnalyticsReportInstanceType.AnalyticsReportInstances => "analyticsReportInstances",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportInstanceType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsReportInstances" => AnalyticsReportInstanceType.AnalyticsReportInstances,
                _ => null,
            };
        }
    }
}