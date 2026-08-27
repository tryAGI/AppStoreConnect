
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization
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
    public static class SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization value)
        {
            return value switch
            {
                SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization.Description => "description",
                SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization.Locale => "locale",
                SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization.Name => "name",
                SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization.State => "state",
                SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization.Description,
                "locale" => SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization.Locale,
                "name" => SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization.Name,
                "state" => SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization.State,
                "subscription" => SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization.Subscription,
                _ => null,
            };
        }
    }
}