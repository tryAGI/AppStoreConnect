
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsReportRequestCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsReportRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportRequestCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportRequestCreateRequestDataType value)
        {
            return value switch
            {
                AnalyticsReportRequestCreateRequestDataType.AnalyticsReportRequests => "analyticsReportRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportRequestCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsReportRequests" => AnalyticsReportRequestCreateRequestDataType.AnalyticsReportRequests,
                _ => null,
            };
        }
    }
}