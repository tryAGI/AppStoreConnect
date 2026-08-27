
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsPromotedPurchasesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseV2,
        /// <summary>
        ///
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsPromotedPurchasesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsPromotedPurchasesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsPromotedPurchasesGetToManyRelatedIncludeItem.InAppPurchaseV2 => "inAppPurchaseV2",
                AppsPromotedPurchasesGetToManyRelatedIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsPromotedPurchasesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseV2" => AppsPromotedPurchasesGetToManyRelatedIncludeItem.InAppPurchaseV2,
                "subscription" => AppsPromotedPurchasesGetToManyRelatedIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}