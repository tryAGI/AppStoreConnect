
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseVersionImageLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseVersionImageLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionImageLinkageResponseDataType value)
        {
            return value switch
            {
                InAppPurchaseVersionImageLinkageResponseDataType.InAppPurchaseImages => "inAppPurchaseImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionImageLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseImages" => InAppPurchaseVersionImageLinkageResponseDataType.InAppPurchaseImages,
                _ => null,
            };
        }
    }
}