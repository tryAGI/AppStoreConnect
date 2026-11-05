
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOfferPriceInlineCreateType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOfferPriceInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOfferPriceInlineCreateType value)
        {
            return value switch
            {
                RetentionOfferPriceInlineCreateType.RetentionOfferPrices => "retentionOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOfferPriceInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOfferPrices" => RetentionOfferPriceInlineCreateType.RetentionOfferPrices,
                _ => null,
            };
        }
    }
}