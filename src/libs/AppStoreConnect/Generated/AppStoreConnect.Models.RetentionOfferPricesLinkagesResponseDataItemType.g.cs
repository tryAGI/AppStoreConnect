
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOfferPricesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOfferPricesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOfferPricesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                RetentionOfferPricesLinkagesResponseDataItemType.RetentionOfferPrices => "retentionOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOfferPricesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOfferPrices" => RetentionOfferPricesLinkagesResponseDataItemType.RetentionOfferPrices,
                _ => null,
            };
        }
    }
}