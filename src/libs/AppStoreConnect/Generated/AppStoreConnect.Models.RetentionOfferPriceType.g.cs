
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOfferPriceType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOfferPriceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOfferPriceType value)
        {
            return value switch
            {
                RetentionOfferPriceType.RetentionOfferPrices => "retentionOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOfferPriceType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOfferPrices" => RetentionOfferPriceType.RetentionOfferPrices,
                _ => null,
            };
        }
    }
}