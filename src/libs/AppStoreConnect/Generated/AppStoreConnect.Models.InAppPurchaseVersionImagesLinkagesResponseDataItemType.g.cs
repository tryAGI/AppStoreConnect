
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseVersionImagesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseVersionImagesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionImagesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                InAppPurchaseVersionImagesLinkagesResponseDataItemType.InAppPurchaseImages => "inAppPurchaseImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionImagesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseImages" => InAppPurchaseVersionImagesLinkagesResponseDataItemType.InAppPurchaseImages,
                _ => null,
            };
        }
    }
}