
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOffersGetInstanceFieldsRetentionOfferPrice
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoint,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOffersGetInstanceFieldsRetentionOfferPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOffersGetInstanceFieldsRetentionOfferPrice value)
        {
            return value switch
            {
                RetentionOffersGetInstanceFieldsRetentionOfferPrice.SubscriptionPricePoint => "subscriptionPricePoint",
                RetentionOffersGetInstanceFieldsRetentionOfferPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOffersGetInstanceFieldsRetentionOfferPrice? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => RetentionOffersGetInstanceFieldsRetentionOfferPrice.SubscriptionPricePoint,
                "territory" => RetentionOffersGetInstanceFieldsRetentionOfferPrice.Territory,
                _ => null,
            };
        }
    }
}