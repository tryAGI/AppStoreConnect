
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePriceRelationshipsInAppPurchasePricePointDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchasePricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceRelationshipsInAppPurchasePricePointDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceRelationshipsInAppPurchasePricePointDataType value)
        {
            return value switch
            {
                InAppPurchasePriceRelationshipsInAppPurchasePricePointDataType.InAppPurchasePricePoints => "inAppPurchasePricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceRelationshipsInAppPurchasePricePointDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePricePoints" => InAppPurchasePriceRelationshipsInAppPurchasePricePointDataType.InAppPurchasePricePoints,
                _ => null,
            };
        }
    }
}