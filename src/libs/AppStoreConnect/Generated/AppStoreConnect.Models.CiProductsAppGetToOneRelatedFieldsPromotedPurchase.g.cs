
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsPromotedPurchase
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
    public static class CiProductsAppGetToOneRelatedFieldsPromotedPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsPromotedPurchase value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsPromotedPurchase.Enabled => "enabled",
                CiProductsAppGetToOneRelatedFieldsPromotedPurchase.InAppPurchaseV2 => "inAppPurchaseV2",
                CiProductsAppGetToOneRelatedFieldsPromotedPurchase.State => "state",
                CiProductsAppGetToOneRelatedFieldsPromotedPurchase.Subscription => "subscription",
                CiProductsAppGetToOneRelatedFieldsPromotedPurchase.VisibleForAllUsers => "visibleForAllUsers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsPromotedPurchase? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CiProductsAppGetToOneRelatedFieldsPromotedPurchase.Enabled,
                "inAppPurchaseV2" => CiProductsAppGetToOneRelatedFieldsPromotedPurchase.InAppPurchaseV2,
                "state" => CiProductsAppGetToOneRelatedFieldsPromotedPurchase.State,
                "subscription" => CiProductsAppGetToOneRelatedFieldsPromotedPurchase.Subscription,
                "visibleForAllUsers" => CiProductsAppGetToOneRelatedFieldsPromotedPurchase.VisibleForAllUsers,
                _ => null,
            };
        }
    }
}