
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsReportRequestCreateRequestDataAttributesAccessType
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
    public static class AnalyticsReportRequestCreateRequestDataAttributesAccessTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportRequestCreateRequestDataAttributesAccessType value)
        {
            return value switch
            {
                AnalyticsReportRequestCreateRequestDataAttributesAccessType.OneTimeSnapshot => "ONE_TIME_SNAPSHOT",
                AnalyticsReportRequestCreateRequestDataAttributesAccessType.Ongoing => "ONGOING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportRequestCreateRequestDataAttributesAccessType? ToEnum(string value)
        {
            return value switch
            {
                "ONE_TIME_SNAPSHOT" => AnalyticsReportRequestCreateRequestDataAttributesAccessType.OneTimeSnapshot,
                "ONGOING" => AnalyticsReportRequestCreateRequestDataAttributesAccessType.Ongoing,
                _ => null,
            };
        }
    }
}