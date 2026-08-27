
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Reports,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAnalyticsReportRequestsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem.Reports => "reports",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "reports" => AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem.Reports,
                _ => null,
            };
        }
    }
}