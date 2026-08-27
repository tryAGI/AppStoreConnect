
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemType value)
        {
            return value switch
            {
                InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemType.Territories,
                _ => null,
            };
        }
    }
}