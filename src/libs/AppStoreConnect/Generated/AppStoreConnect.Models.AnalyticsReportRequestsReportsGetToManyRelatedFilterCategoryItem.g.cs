
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreEngagement,
        /// <summary>
        /// 
        /// </summary>
        AppUsage,
        /// <summary>
        /// 
        /// </summary>
        Commerce,
        /// <summary>
        /// 
        /// </summary>
        FrameworkUsage,
        /// <summary>
        /// 
        /// </summary>
        Performance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem value)
        {
            return value switch
            {
                AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem.AppStoreEngagement => "APP_STORE_ENGAGEMENT",
                AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem.AppUsage => "APP_USAGE",
                AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem.Commerce => "COMMERCE",
                AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem.FrameworkUsage => "FRAMEWORK_USAGE",
                AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem.Performance => "PERFORMANCE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem? ToEnum(string value)
        {
            return value switch
            {
                "APP_STORE_ENGAGEMENT" => AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem.AppStoreEngagement,
                "APP_USAGE" => AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem.AppUsage,
                "COMMERCE" => AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem.Commerce,
                "FRAMEWORK_USAGE" => AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem.FrameworkUsage,
                "PERFORMANCE" => AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem.Performance,
                _ => null,
            };
        }
    }
}