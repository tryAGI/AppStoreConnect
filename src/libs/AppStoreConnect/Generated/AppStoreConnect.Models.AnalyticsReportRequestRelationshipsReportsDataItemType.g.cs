
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsReportRequestRelationshipsReportsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AnalyticsReports,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportRequestRelationshipsReportsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportRequestRelationshipsReportsDataItemType value)
        {
            return value switch
            {
                AnalyticsReportRequestRelationshipsReportsDataItemType.AnalyticsReports => "analyticsReports",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportRequestRelationshipsReportsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsReports" => AnalyticsReportRequestRelationshipsReportsDataItemType.AnalyticsReports,
                _ => null,
            };
        }
    }
}