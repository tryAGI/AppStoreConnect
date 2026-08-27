
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsReportAttributesCategory
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
    public static class AnalyticsReportAttributesCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportAttributesCategory value)
        {
            return value switch
            {
                AnalyticsReportAttributesCategory.AppStoreEngagement => "APP_STORE_ENGAGEMENT",
                AnalyticsReportAttributesCategory.AppUsage => "APP_USAGE",
                AnalyticsReportAttributesCategory.Commerce => "COMMERCE",
                AnalyticsReportAttributesCategory.FrameworkUsage => "FRAMEWORK_USAGE",
                AnalyticsReportAttributesCategory.Performance => "PERFORMANCE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportAttributesCategory? ToEnum(string value)
        {
            return value switch
            {
                "APP_STORE_ENGAGEMENT" => AnalyticsReportAttributesCategory.AppStoreEngagement,
                "APP_USAGE" => AnalyticsReportAttributesCategory.AppUsage,
                "COMMERCE" => AnalyticsReportAttributesCategory.Commerce,
                "FRAMEWORK_USAGE" => AnalyticsReportAttributesCategory.FrameworkUsage,
                "PERFORMANCE" => AnalyticsReportAttributesCategory.Performance,
                _ => null,
            };
        }
    }
}