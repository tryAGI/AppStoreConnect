
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsReportsInstancesGetToManyRelatedFieldsAnalyticsReportInstance
    {
        /// <summary>
        ///
        /// </summary>
        Granularity,
        /// <summary>
        ///
        /// </summary>
        ProcessingDate,
        /// <summary>
        ///
        /// </summary>
        Segments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsReportsInstancesGetToManyRelatedFieldsAnalyticsReportInstanceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportsInstancesGetToManyRelatedFieldsAnalyticsReportInstance value)
        {
            return value switch
            {
                AnalyticsReportsInstancesGetToManyRelatedFieldsAnalyticsReportInstance.Granularity => "granularity",
                AnalyticsReportsInstancesGetToManyRelatedFieldsAnalyticsReportInstance.ProcessingDate => "processingDate",
                AnalyticsReportsInstancesGetToManyRelatedFieldsAnalyticsReportInstance.Segments => "segments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportsInstancesGetToManyRelatedFieldsAnalyticsReportInstance? ToEnum(string value)
        {
            return value switch
            {
                "granularity" => AnalyticsReportsInstancesGetToManyRelatedFieldsAnalyticsReportInstance.Granularity,
                "processingDate" => AnalyticsReportsInstancesGetToManyRelatedFieldsAnalyticsReportInstance.ProcessingDate,
                "segments" => AnalyticsReportsInstancesGetToManyRelatedFieldsAnalyticsReportInstance.Segments,
                _ => null,
            };
        }
    }
}