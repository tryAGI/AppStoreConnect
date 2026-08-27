
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsReportRequestType
    {
        /// <summary>
        ///
        /// </summary>
        AnalyticsReportRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportRequestType value)
        {
            return value switch
            {
                AnalyticsReportRequestType.AnalyticsReportRequests => "analyticsReportRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportRequestType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsReportRequests" => AnalyticsReportRequestType.AnalyticsReportRequests,
                _ => null,
            };
        }
    }
}