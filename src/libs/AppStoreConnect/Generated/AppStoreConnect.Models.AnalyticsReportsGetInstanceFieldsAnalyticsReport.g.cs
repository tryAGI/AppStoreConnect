
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsReportsGetInstanceFieldsAnalyticsReport
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
    public static class AnalyticsReportsGetInstanceFieldsAnalyticsReportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsReportsGetInstanceFieldsAnalyticsReport value)
        {
            return value switch
            {
                AnalyticsReportsGetInstanceFieldsAnalyticsReport.Category => "category",
                AnalyticsReportsGetInstanceFieldsAnalyticsReport.Instances => "instances",
                AnalyticsReportsGetInstanceFieldsAnalyticsReport.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsReportsGetInstanceFieldsAnalyticsReport? ToEnum(string value)
        {
            return value switch
            {
                "category" => AnalyticsReportsGetInstanceFieldsAnalyticsReport.Category,
                "instances" => AnalyticsReportsGetInstanceFieldsAnalyticsReport.Instances,
                "name" => AnalyticsReportsGetInstanceFieldsAnalyticsReport.Name,
                _ => null,
            };
        }
    }
}