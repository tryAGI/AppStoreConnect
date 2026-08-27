
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Subscription,
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
    public static class SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem.Subscription => "subscription",
                SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscription" => SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem.Subscription,
                "subscriptionPricePoint" => SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem.SubscriptionPricePoint,
                "territory" => SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}