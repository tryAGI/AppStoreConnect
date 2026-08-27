
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinanceReportsGetCollectionFilterReportTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        FinanceDetail,
        /// <summary>
        /// 
        /// </summary>
        Financial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinanceReportsGetCollectionFilterReportTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinanceReportsGetCollectionFilterReportTypeItem value)
        {
            return value switch
            {
                FinanceReportsGetCollectionFilterReportTypeItem.FinanceDetail => "FINANCE_DETAIL",
                FinanceReportsGetCollectionFilterReportTypeItem.Financial => "FINANCIAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinanceReportsGetCollectionFilterReportTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "FINANCE_DETAIL" => FinanceReportsGetCollectionFilterReportTypeItem.FinanceDetail,
                "FINANCIAL" => FinanceReportsGetCollectionFilterReportTypeItem.Financial,
                _ => null,
            };
        }
    }
}