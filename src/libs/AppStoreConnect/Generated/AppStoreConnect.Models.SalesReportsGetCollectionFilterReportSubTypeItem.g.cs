
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SalesReportsGetCollectionFilterReportSubTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Detailed,
        /// <summary>
        /// 
        /// </summary>
        Summary,
        /// <summary>
        /// 
        /// </summary>
        SummaryChannel,
        /// <summary>
        /// 
        /// </summary>
        SummaryInstallType,
        /// <summary>
        /// 
        /// </summary>
        SummaryTerritory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SalesReportsGetCollectionFilterReportSubTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SalesReportsGetCollectionFilterReportSubTypeItem value)
        {
            return value switch
            {
                SalesReportsGetCollectionFilterReportSubTypeItem.Detailed => "DETAILED",
                SalesReportsGetCollectionFilterReportSubTypeItem.Summary => "SUMMARY",
                SalesReportsGetCollectionFilterReportSubTypeItem.SummaryChannel => "SUMMARY_CHANNEL",
                SalesReportsGetCollectionFilterReportSubTypeItem.SummaryInstallType => "SUMMARY_INSTALL_TYPE",
                SalesReportsGetCollectionFilterReportSubTypeItem.SummaryTerritory => "SUMMARY_TERRITORY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SalesReportsGetCollectionFilterReportSubTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "DETAILED" => SalesReportsGetCollectionFilterReportSubTypeItem.Detailed,
                "SUMMARY" => SalesReportsGetCollectionFilterReportSubTypeItem.Summary,
                "SUMMARY_CHANNEL" => SalesReportsGetCollectionFilterReportSubTypeItem.SummaryChannel,
                "SUMMARY_INSTALL_TYPE" => SalesReportsGetCollectionFilterReportSubTypeItem.SummaryInstallType,
                "SUMMARY_TERRITORY" => SalesReportsGetCollectionFilterReportSubTypeItem.SummaryTerritory,
                _ => null,
            };
        }
    }
}