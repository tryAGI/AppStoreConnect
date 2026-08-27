
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsReportsInstancesGetToManyRelatedFilterGranularityItem
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportsInstancesGetToManyRelatedFilterGranularityItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportsInstancesGetToManyRelatedFilterGranularityItem value)
        {
            return value switch
            {
                AnalyticsReportsInstancesGetToManyRelatedFilterGranularityItem.Daily => "DAILY",
                AnalyticsReportsInstancesGetToManyRelatedFilterGranularityItem.Monthly => "MONTHLY",
                AnalyticsReportsInstancesGetToManyRelatedFilterGranularityItem.Weekly => "WEEKLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportsInstancesGetToManyRelatedFilterGranularityItem? ToEnum(string value)
        {
            return value switch
            {
                "DAILY" => AnalyticsReportsInstancesGetToManyRelatedFilterGranularityItem.Daily,
                "MONTHLY" => AnalyticsReportsInstancesGetToManyRelatedFilterGranularityItem.Monthly,
                "WEEKLY" => AnalyticsReportsInstancesGetToManyRelatedFilterGranularityItem.Weekly,
                _ => null,
            };
        }
    }
}