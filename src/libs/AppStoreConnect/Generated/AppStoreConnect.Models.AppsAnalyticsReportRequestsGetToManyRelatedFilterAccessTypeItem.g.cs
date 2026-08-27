
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        OneTimeSnapshot,
        /// <summary>
        /// 
        /// </summary>
        Ongoing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem value)
        {
            return value switch
            {
                AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem.OneTimeSnapshot => "ONE_TIME_SNAPSHOT",
                AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem.Ongoing => "ONGOING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "ONE_TIME_SNAPSHOT" => AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem.OneTimeSnapshot,
                "ONGOING" => AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem.Ongoing,
                _ => null,
            };
        }
    }
}