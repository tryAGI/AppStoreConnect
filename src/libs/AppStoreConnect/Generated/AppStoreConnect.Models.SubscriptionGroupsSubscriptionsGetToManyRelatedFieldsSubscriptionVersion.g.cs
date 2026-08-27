
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Image => "image",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Images => "images",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Localizations => "localizations",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.State => "state",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Subscription => "subscription",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "image" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Image,
                "images" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Images,
                "localizations" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Localizations,
                "state" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.State,
                "subscription" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Subscription,
                "version" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion.Version,
                _ => null,
            };
        }
    }
}