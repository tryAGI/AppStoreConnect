
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsPromotedPurchase
    {
        /// <summary>
        ///
        /// </summary>
        Enabled,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseV2,
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
        VisibleForAllUsers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGetCollectionFieldsPromotedPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsPromotedPurchase value)
        {
            return value switch
            {
                AppsGetCollectionFieldsPromotedPurchase.Enabled => "enabled",
                AppsGetCollectionFieldsPromotedPurchase.InAppPurchaseV2 => "inAppPurchaseV2",
                AppsGetCollectionFieldsPromotedPurchase.State => "state",
                AppsGetCollectionFieldsPromotedPurchase.Subscription => "subscription",
                AppsGetCollectionFieldsPromotedPurchase.VisibleForAllUsers => "visibleForAllUsers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsPromotedPurchase? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => AppsGetCollectionFieldsPromotedPurchase.Enabled,
                "inAppPurchaseV2" => AppsGetCollectionFieldsPromotedPurchase.InAppPurchaseV2,
                "state" => AppsGetCollectionFieldsPromotedPurchase.State,
                "subscription" => AppsGetCollectionFieldsPromotedPurchase.Subscription,
                "visibleForAllUsers" => AppsGetCollectionFieldsPromotedPurchase.VisibleForAllUsers,
                _ => null,
            };
        }
    }
}