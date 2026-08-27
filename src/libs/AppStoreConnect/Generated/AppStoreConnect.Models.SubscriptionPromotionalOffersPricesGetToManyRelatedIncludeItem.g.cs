
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem
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
    public static class SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem.SubscriptionPricePoint,
                "territory" => SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}