
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseV2RelationshipsContentDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseContents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2RelationshipsContentDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2RelationshipsContentDataType value)
        {
            return value switch
            {
                InAppPurchaseV2RelationshipsContentDataType.InAppPurchaseContents => "inAppPurchaseContents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2RelationshipsContentDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseContents" => InAppPurchaseV2RelationshipsContentDataType.InAppPurchaseContents,
                _ => null,
            };
        }
    }
}