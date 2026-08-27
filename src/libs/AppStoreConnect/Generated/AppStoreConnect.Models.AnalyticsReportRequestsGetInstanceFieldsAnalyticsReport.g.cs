
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport
    {
        /// <summary>
        /// 
        /// </summary>
        Category,
        /// <summary>
        /// 
        /// </summary>
        Instances,
        /// <summary>
        /// 
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportRequestsGetInstanceFieldsAnalyticsReportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport value)
        {
            return value switch
            {
                AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport.Category => "category",
                AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport.Instances => "instances",
                AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport? ToEnum(string value)
        {
            return value switch
            {
                "category" => AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport.Category,
                "instances" => AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport.Instances,
                "name" => AnalyticsReportRequestsGetInstanceFieldsAnalyticsReport.Name,
                _ => null,
            };
        }
    }
}