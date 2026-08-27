
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFieldsSubscriptionGroup
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
    public static class AppsGetCollectionFieldsSubscriptionGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsSubscriptionGroup value)
        {
            return value switch
            {
                AppsGetCollectionFieldsSubscriptionGroup.ReferenceName => "referenceName",
                AppsGetCollectionFieldsSubscriptionGroup.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                AppsGetCollectionFieldsSubscriptionGroup.Subscriptions => "subscriptions",
                AppsGetCollectionFieldsSubscriptionGroup.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsSubscriptionGroup? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => AppsGetCollectionFieldsSubscriptionGroup.ReferenceName,
                "subscriptionGroupLocalizations" => AppsGetCollectionFieldsSubscriptionGroup.SubscriptionGroupLocalizations,
                "subscriptions" => AppsGetCollectionFieldsSubscriptionGroup.Subscriptions,
                "versions" => AppsGetCollectionFieldsSubscriptionGroup.Versions,
                _ => null,
            };
        }
    }
}