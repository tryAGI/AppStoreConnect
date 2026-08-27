
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsSubscriptionVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Images,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsGetInstanceFieldsSubscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsSubscriptionVersion value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsSubscriptionVersion.Image => "image",
                SubscriptionsGetInstanceFieldsSubscriptionVersion.Images => "images",
                SubscriptionsGetInstanceFieldsSubscriptionVersion.Localizations => "localizations",
                SubscriptionsGetInstanceFieldsSubscriptionVersion.State => "state",
                SubscriptionsGetInstanceFieldsSubscriptionVersion.Subscription => "subscription",
                SubscriptionsGetInstanceFieldsSubscriptionVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsSubscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => SubscriptionsGetInstanceFieldsSubscriptionVersion.Image,
                "images" => SubscriptionsGetInstanceFieldsSubscriptionVersion.Images,
                "localizations" => SubscriptionsGetInstanceFieldsSubscriptionVersion.Localizations,
                "state" => SubscriptionsGetInstanceFieldsSubscriptionVersion.State,
                "subscription" => SubscriptionsGetInstanceFieldsSubscriptionVersion.Subscription,
                "version" => SubscriptionsGetInstanceFieldsSubscriptionVersion.Version,
                _ => null,
            };
        }
    }
}