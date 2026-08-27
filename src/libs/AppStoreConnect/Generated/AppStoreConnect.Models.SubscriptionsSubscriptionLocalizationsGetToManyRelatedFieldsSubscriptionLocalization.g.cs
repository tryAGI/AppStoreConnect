
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization
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
    public static class SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization value)
        {
            return value switch
            {
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Description => "description",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Locale => "locale",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Name => "name",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.State => "state",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Description,
                "locale" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Locale,
                "name" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Name,
                "state" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.State,
                "subscription" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionLocalization.Subscription,
                _ => null,
            };
        }
    }
}