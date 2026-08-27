
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseContentType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseContents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseContentType value)
        {
            return value switch
            {
                InAppPurchaseContentType.InAppPurchaseContents => "inAppPurchaseContents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseContentType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseContents" => InAppPurchaseContentType.InAppPurchaseContents,
                _ => null,
            };
        }
    }
}