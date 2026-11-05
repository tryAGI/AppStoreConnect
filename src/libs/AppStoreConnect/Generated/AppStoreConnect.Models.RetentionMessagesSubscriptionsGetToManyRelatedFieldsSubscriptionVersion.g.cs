
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion
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
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Image => "image",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Images => "images",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Localizations => "localizations",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.State => "state",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Subscription => "subscription",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Image,
                "images" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Images,
                "localizations" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Localizations,
                "state" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.State,
                "subscription" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Subscription,
                "version" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Version,
                _ => null,
            };
        }
    }
}