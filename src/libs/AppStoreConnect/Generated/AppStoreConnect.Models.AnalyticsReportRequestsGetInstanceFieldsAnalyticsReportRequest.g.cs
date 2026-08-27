
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest
    {
        /// <summary>
        ///
        /// </summary>
        AccessType,
        /// <summary>
        ///
        /// </summary>
        Reports,
        /// <summary>
        ///
        /// </summary>
        StoppedDueToInactivity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest value)
        {
            return value switch
            {
                AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest.AccessType => "accessType",
                AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest.Reports => "reports",
                AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest.StoppedDueToInactivity => "stoppedDueToInactivity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest? ToEnum(string value)
        {
            return value switch
            {
                "accessType" => AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest.AccessType,
                "reports" => AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest.Reports,
                "stoppedDueToInactivity" => AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportRequest.StoppedDueToInactivity,
                _ => null,
            };
        }
    }
}