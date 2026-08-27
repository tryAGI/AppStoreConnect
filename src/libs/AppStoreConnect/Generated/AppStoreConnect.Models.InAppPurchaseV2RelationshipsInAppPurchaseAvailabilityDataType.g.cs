
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType value)
        {
            return value switch
            {
                InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType.InAppPurchaseAvailabilities => "inAppPurchaseAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseAvailabilities" => InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType.InAppPurchaseAvailabilities,
                _ => null,
            };
        }
    }
}