
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroup
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
    public static class AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroup value)
        {
            return value switch
            {
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroup.ReferenceName => "referenceName",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroup.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroup.Subscriptions => "subscriptions",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroup.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroup? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroup.ReferenceName,
                "subscriptionGroupLocalizations" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroup.SubscriptionGroupLocalizations,
                "subscriptions" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroup.Subscriptions,
                "versions" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroup.Versions,
                _ => null,
            };
        }
    }
}