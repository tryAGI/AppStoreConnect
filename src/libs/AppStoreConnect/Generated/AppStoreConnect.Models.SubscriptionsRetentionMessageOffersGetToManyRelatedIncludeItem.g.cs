
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsRetentionMessageOffersGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Prices,
        /// <summary>
        ///
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsRetentionMessageOffersGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsRetentionMessageOffersGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsRetentionMessageOffersGetToManyRelatedIncludeItem.Prices => "prices",
                SubscriptionsRetentionMessageOffersGetToManyRelatedIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsRetentionMessageOffersGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "prices" => SubscriptionsRetentionMessageOffersGetToManyRelatedIncludeItem.Prices,
                "subscription" => SubscriptionsRetentionMessageOffersGetToManyRelatedIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}