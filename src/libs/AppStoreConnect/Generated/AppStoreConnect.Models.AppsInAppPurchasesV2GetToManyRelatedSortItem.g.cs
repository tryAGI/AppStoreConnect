
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedSortItem
    {
        /// <summary>
        ///
        /// </summary>
        MinusinAppPurchaseType,
        /// <summary>
        ///
        /// </summary>
        Minusname,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseType,
        /// <summary>
        ///
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsInAppPurchasesV2GetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedSortItem.MinusinAppPurchaseType => "-inAppPurchaseType",
                AppsInAppPurchasesV2GetToManyRelatedSortItem.Minusname => "-name",
                AppsInAppPurchasesV2GetToManyRelatedSortItem.InAppPurchaseType => "inAppPurchaseType",
                AppsInAppPurchasesV2GetToManyRelatedSortItem.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-inAppPurchaseType" => AppsInAppPurchasesV2GetToManyRelatedSortItem.MinusinAppPurchaseType,
                "-name" => AppsInAppPurchasesV2GetToManyRelatedSortItem.Minusname,
                "inAppPurchaseType" => AppsInAppPurchasesV2GetToManyRelatedSortItem.InAppPurchaseType,
                "name" => AppsInAppPurchasesV2GetToManyRelatedSortItem.Name,
                _ => null,
            };
        }
    }
}