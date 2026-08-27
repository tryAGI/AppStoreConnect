
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseV2UpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2UpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2UpdateRequestDataType value)
        {
            return value switch
            {
                InAppPurchaseV2UpdateRequestDataType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2UpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => InAppPurchaseV2UpdateRequestDataType.InAppPurchases,
                _ => null,
            };
        }
    }
}