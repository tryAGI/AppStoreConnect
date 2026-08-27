
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport
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
    public static class AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport value)
        {
            return value switch
            {
                AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport.Category => "category",
                AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport.Instances => "instances",
                AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport.Category,
                "instances" => AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport.Instances,
                "name" => AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport.Name,
                _ => null,
            };
        }
    }
}