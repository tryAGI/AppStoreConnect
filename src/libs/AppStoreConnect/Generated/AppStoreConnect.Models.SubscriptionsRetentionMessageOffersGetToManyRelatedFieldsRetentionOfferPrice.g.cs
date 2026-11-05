
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOfferPrice
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
    public static class SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOfferPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOfferPrice value)
        {
            return value switch
            {
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOfferPrice.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOfferPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOfferPrice? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOfferPrice.SubscriptionPricePoint,
                "territory" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsRetentionOfferPrice.Territory,
                _ => null,
            };
        }
    }
}