
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsSubscriptionGroup
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
    public static class CiProductsAppGetToOneRelatedFieldsSubscriptionGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsSubscriptionGroup value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsSubscriptionGroup.ReferenceName => "referenceName",
                CiProductsAppGetToOneRelatedFieldsSubscriptionGroup.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                CiProductsAppGetToOneRelatedFieldsSubscriptionGroup.Subscriptions => "subscriptions",
                CiProductsAppGetToOneRelatedFieldsSubscriptionGroup.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsSubscriptionGroup? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => CiProductsAppGetToOneRelatedFieldsSubscriptionGroup.ReferenceName,
                "subscriptionGroupLocalizations" => CiProductsAppGetToOneRelatedFieldsSubscriptionGroup.SubscriptionGroupLocalizations,
                "subscriptions" => CiProductsAppGetToOneRelatedFieldsSubscriptionGroup.Subscriptions,
                "versions" => CiProductsAppGetToOneRelatedFieldsSubscriptionGroup.Versions,
                _ => null,
            };
        }
    }
}