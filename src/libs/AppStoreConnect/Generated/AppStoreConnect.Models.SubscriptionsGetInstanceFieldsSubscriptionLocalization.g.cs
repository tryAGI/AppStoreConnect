
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsSubscriptionLocalization
    {
        /// <summary>
        ///
        /// </summary>
        Description,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsGetInstanceFieldsSubscriptionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsSubscriptionLocalization value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsSubscriptionLocalization.Description => "description",
                SubscriptionsGetInstanceFieldsSubscriptionLocalization.Locale => "locale",
                SubscriptionsGetInstanceFieldsSubscriptionLocalization.Name => "name",
                SubscriptionsGetInstanceFieldsSubscriptionLocalization.State => "state",
                SubscriptionsGetInstanceFieldsSubscriptionLocalization.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsSubscriptionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => SubscriptionsGetInstanceFieldsSubscriptionLocalization.Description,
                "locale" => SubscriptionsGetInstanceFieldsSubscriptionLocalization.Locale,
                "name" => SubscriptionsGetInstanceFieldsSubscriptionLocalization.Name,
                "state" => SubscriptionsGetInstanceFieldsSubscriptionLocalization.State,
                "subscription" => SubscriptionsGetInstanceFieldsSubscriptionLocalization.Subscription,
                _ => null,
            };
        }
    }
}