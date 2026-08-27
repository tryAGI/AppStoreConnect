
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2VersionsGetToManyRelatedIncludeItem
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
        InAppPurchase,
        /// <summary>
        ///
        /// </summary>
        Localizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2VersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2VersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                InAppPurchasesV2VersionsGetToManyRelatedIncludeItem.Image => "image",
                InAppPurchasesV2VersionsGetToManyRelatedIncludeItem.Images => "images",
                InAppPurchasesV2VersionsGetToManyRelatedIncludeItem.InAppPurchase => "inAppPurchase",
                InAppPurchasesV2VersionsGetToManyRelatedIncludeItem.Localizations => "localizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2VersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => InAppPurchasesV2VersionsGetToManyRelatedIncludeItem.Image,
                "images" => InAppPurchasesV2VersionsGetToManyRelatedIncludeItem.Images,
                "inAppPurchase" => InAppPurchasesV2VersionsGetToManyRelatedIncludeItem.InAppPurchase,
                "localizations" => InAppPurchasesV2VersionsGetToManyRelatedIncludeItem.Localizations,
                _ => null,
            };
        }
    }
}