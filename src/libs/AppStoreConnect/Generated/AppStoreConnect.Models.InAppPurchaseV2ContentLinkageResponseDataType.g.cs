
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseV2ContentLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseContents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2ContentLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2ContentLinkageResponseDataType value)
        {
            return value switch
            {
                InAppPurchaseV2ContentLinkageResponseDataType.InAppPurchaseContents => "inAppPurchaseContents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2ContentLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseContents" => InAppPurchaseV2ContentLinkageResponseDataType.InAppPurchaseContents,
                _ => null,
            };
        }
    }
}