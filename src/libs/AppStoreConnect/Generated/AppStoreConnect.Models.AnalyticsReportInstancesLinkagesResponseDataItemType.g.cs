
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsReportInstancesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsReportInstances,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportInstancesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportInstancesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AnalyticsReportInstancesLinkagesResponseDataItemType.AnalyticsReportInstances => "analyticsReportInstances",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportInstancesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsReportInstances" => AnalyticsReportInstancesLinkagesResponseDataItemType.AnalyticsReportInstances,
                _ => null,
            };
        }
    }
}