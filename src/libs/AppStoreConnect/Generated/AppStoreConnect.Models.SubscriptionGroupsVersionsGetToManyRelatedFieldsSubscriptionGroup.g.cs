
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup
    {
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupLocalizations,
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
        /// <summary>
        ///
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup value)
        {
            return value switch
            {
                SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup.ReferenceName => "referenceName",
                SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup.Subscriptions => "subscriptions",
                SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup.ReferenceName,
                "subscriptionGroupLocalizations" => SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup.SubscriptionGroupLocalizations,
                "subscriptions" => SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup.Subscriptions,
                "versions" => SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup.Versions,
                _ => null,
            };
        }
    }
}