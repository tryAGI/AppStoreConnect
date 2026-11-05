
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOfferRelationshipsPricesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOfferRelationshipsPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOfferRelationshipsPricesDataItemType value)
        {
            return value switch
            {
                RetentionOfferRelationshipsPricesDataItemType.RetentionOfferPrices => "retentionOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOfferRelationshipsPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOfferPrices" => RetentionOfferRelationshipsPricesDataItemType.RetentionOfferPrices,
                _ => null,
            };
        }
    }
}