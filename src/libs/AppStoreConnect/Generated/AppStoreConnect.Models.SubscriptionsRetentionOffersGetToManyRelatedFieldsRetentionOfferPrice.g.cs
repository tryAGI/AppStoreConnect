
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOfferPrice
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
    public static class SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOfferPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOfferPrice value)
        {
            return value switch
            {
                SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOfferPrice.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOfferPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOfferPrice? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOfferPrice.SubscriptionPricePoint,
                "territory" => SubscriptionsRetentionOffersGetToManyRelatedFieldsRetentionOfferPrice.Territory,
                _ => null,
            };
        }
    }
}