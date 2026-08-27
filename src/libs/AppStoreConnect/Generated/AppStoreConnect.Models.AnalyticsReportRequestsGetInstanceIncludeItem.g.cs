
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsReportRequestsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Reports,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportRequestsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportRequestsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AnalyticsReportRequestsGetInstanceIncludeItem.Reports => "reports",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportRequestsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "reports" => AnalyticsReportRequestsGetInstanceIncludeItem.Reports,
                _ => null,
            };
        }
    }
}