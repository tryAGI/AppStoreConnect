
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseImageUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseImageUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseImageUpdateRequestDataType value)
        {
            return value switch
            {
                InAppPurchaseImageUpdateRequestDataType.InAppPurchaseImages => "inAppPurchaseImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseImageUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseImages" => InAppPurchaseImageUpdateRequestDataType.InAppPurchaseImages,
                _ => null,
            };
        }
    }
}