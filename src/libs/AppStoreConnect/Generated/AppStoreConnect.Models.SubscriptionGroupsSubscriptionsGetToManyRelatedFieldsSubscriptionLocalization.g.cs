
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Description => "description",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Locale => "locale",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Name => "name",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.State => "state",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Description,
                "locale" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Locale,
                "name" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Name,
                "state" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.State,
                "subscription" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Subscription,
                _ => null,
            };
        }
    }
}