
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance
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
    public static class AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstanceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance value)
        {
            return value switch
            {
                AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance.Granularity => "granularity",
                AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance.ProcessingDate => "processingDate",
                AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance.Segments => "segments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance? ToEnum(string value)
        {
            return value switch
            {
                "granularity" => AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance.Granularity,
                "processingDate" => AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance.ProcessingDate,
                "segments" => AnalyticsReportInstancesGetInstanceFieldsAnalyticsReportInstance.Segments,
                _ => null,
            };
        }
    }
}