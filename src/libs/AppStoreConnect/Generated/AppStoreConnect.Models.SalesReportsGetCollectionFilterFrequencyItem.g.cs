
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SalesReportsGetCollectionFilterFrequencyItem
    {
        /// <summary>
        ///
        /// </summary>
        Daily,
        /// <summary>
        ///
        /// </summary>
        Monthly,
        /// <summary>
        ///
        /// </summary>
        Weekly,
        /// <summary>
        ///
        /// </summary>
        Yearly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SalesReportsGetCollectionFilterFrequencyItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SalesReportsGetCollectionFilterFrequencyItem value)
        {
            return value switch
            {
                SalesReportsGetCollectionFilterFrequencyItem.Daily => "DAILY",
                SalesReportsGetCollectionFilterFrequencyItem.Monthly => "MONTHLY",
                SalesReportsGetCollectionFilterFrequencyItem.Weekly => "WEEKLY",
                SalesReportsGetCollectionFilterFrequencyItem.Yearly => "YEARLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SalesReportsGetCollectionFilterFrequencyItem? ToEnum(string value)
        {
            return value switch
            {
                "DAILY" => SalesReportsGetCollectionFilterFrequencyItem.Daily,
                "MONTHLY" => SalesReportsGetCollectionFilterFrequencyItem.Monthly,
                "WEEKLY" => SalesReportsGetCollectionFilterFrequencyItem.Weekly,
                "YEARLY" => SalesReportsGetCollectionFilterFrequencyItem.Yearly,
                _ => null,
            };
        }
    }
}