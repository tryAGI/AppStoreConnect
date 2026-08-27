
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataType value)
        {
            return value switch
            {
                InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataType.InAppPurchasePricePoints => "inAppPurchasePricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePricePoints" => InAppPurchasePriceInlineCreateRelationshipsInAppPurchasePricePointDataType.InAppPurchasePricePoints,
                _ => null,
            };
        }
    }
}