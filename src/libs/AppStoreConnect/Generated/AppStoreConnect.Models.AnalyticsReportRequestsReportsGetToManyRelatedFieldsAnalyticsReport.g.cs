
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport
    {
        /// <summary>
        ///
        /// </summary>
        Category,
        /// <summary>
        ///
        /// </summary>
        Instances,
        /// <summary>
        ///
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport value)
        {
            return value switch
            {
                AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport.Category => "category",
                AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport.Instances => "instances",
                AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport? ToEnum(string value)
        {
            return value switch
            {
                "category" => AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport.Category,
                "instances" => AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport.Instances,
                "name" => AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport.Name,
                _ => null,
            };
        }
    }
}