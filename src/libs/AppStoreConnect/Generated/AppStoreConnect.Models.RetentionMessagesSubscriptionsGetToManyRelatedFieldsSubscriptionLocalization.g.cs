
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization
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
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Description => "description",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Locale => "locale",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Name => "name",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.State => "state",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Description,
                "locale" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Locale,
                "name" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Name,
                "state" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.State,
                "subscription" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization.Subscription,
                _ => null,
            };
        }
    }
}