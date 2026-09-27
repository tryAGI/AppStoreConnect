
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPerformanceOverviewsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        PerformanceOverviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPerformanceOverviewsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPerformanceOverviewsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppPerformanceOverviewsLinkagesResponseDataItemType.PerformanceOverviews => "performanceOverviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPerformanceOverviewsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "performanceOverviews" => AppPerformanceOverviewsLinkagesResponseDataItemType.PerformanceOverviews,
                _ => null,
            };
        }
    }
}