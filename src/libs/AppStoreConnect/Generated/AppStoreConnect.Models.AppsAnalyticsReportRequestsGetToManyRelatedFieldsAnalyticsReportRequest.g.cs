
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest
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
    public static class AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest value)
        {
            return value switch
            {
                AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest.AccessType => "accessType",
                AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest.Reports => "reports",
                AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest.StoppedDueToInactivity => "stoppedDueToInactivity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest? ToEnum(string value)
        {
            return value switch
            {
                "accessType" => AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest.AccessType,
                "reports" => AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest.Reports,
                "stoppedDueToInactivity" => AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest.StoppedDueToInactivity,
                _ => null,
            };
        }
    }
}