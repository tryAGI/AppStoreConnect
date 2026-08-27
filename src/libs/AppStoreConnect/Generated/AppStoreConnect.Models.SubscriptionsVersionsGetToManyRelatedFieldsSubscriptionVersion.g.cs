
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion
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
    public static class SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion value)
        {
            return value switch
            {
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion.Image => "image",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion.Images => "images",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion.Localizations => "localizations",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion.State => "state",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion.Subscription => "subscription",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion.Image,
                "images" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion.Images,
                "localizations" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion.Localizations,
                "state" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion.State,
                "subscription" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion.Subscription,
                "version" => SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion.Version,
                _ => null,
            };
        }
    }
}