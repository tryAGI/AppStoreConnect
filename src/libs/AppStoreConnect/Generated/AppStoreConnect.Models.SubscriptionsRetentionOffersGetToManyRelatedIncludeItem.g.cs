
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsRetentionOffersGetToManyRelatedIncludeItem
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
    public static class SubscriptionsRetentionOffersGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsRetentionOffersGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsRetentionOffersGetToManyRelatedIncludeItem.Prices => "prices",
                SubscriptionsRetentionOffersGetToManyRelatedIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsRetentionOffersGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "prices" => SubscriptionsRetentionOffersGetToManyRelatedIncludeItem.Prices,
                "subscription" => SubscriptionsRetentionOffersGetToManyRelatedIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}