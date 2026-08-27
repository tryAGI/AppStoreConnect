
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseImageCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseImageCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseImageCreateRequestDataType value)
        {
            return value switch
            {
                InAppPurchaseImageCreateRequestDataType.InAppPurchaseImages => "inAppPurchaseImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseImageCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseImages" => InAppPurchaseImageCreateRequestDataType.InAppPurchaseImages,
                _ => null,
            };
        }
    }
}