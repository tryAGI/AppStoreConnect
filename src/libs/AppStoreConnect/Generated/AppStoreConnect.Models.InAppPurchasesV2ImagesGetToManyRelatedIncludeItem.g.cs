
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2ImagesGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2ImagesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2ImagesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                InAppPurchasesV2ImagesGetToManyRelatedIncludeItem.InAppPurchase => "inAppPurchase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2ImagesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchase" => InAppPurchasesV2ImagesGetToManyRelatedIncludeItem.InAppPurchase,
                _ => null,
            };
        }
    }
}