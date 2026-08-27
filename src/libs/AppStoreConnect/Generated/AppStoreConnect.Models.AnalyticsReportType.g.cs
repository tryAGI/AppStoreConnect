
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsReportType
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsReports,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportType value)
        {
            return value switch
            {
                AnalyticsReportType.AnalyticsReports => "analyticsReports",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsReports" => AnalyticsReportType.AnalyticsReports,
                _ => null,
            };
        }
    }
}