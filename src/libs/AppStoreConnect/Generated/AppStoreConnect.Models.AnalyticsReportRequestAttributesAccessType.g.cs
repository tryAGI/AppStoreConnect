
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsReportRequestAttributesAccessType
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
    public static class AnalyticsReportRequestAttributesAccessTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportRequestAttributesAccessType value)
        {
            return value switch
            {
                AnalyticsReportRequestAttributesAccessType.OneTimeSnapshot => "ONE_TIME_SNAPSHOT",
                AnalyticsReportRequestAttributesAccessType.Ongoing => "ONGOING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportRequestAttributesAccessType? ToEnum(string value)
        {
            return value switch
            {
                "ONE_TIME_SNAPSHOT" => AnalyticsReportRequestAttributesAccessType.OneTimeSnapshot,
                "ONGOING" => AnalyticsReportRequestAttributesAccessType.Ongoing,
                _ => null,
            };
        }
    }
}