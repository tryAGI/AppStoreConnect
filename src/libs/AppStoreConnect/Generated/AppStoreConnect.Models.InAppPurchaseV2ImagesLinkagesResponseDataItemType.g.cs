
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseV2ImagesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2ImagesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2ImagesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                InAppPurchaseV2ImagesLinkagesResponseDataItemType.InAppPurchaseImages => "inAppPurchaseImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2ImagesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseImages" => InAppPurchaseV2ImagesLinkagesResponseDataItemType.InAppPurchaseImages,
                _ => null,
            };
        }
    }
}