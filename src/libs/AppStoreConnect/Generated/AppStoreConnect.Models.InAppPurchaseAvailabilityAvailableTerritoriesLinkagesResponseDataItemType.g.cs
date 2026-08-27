
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseAvailabilityAvailableTerritoriesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAvailabilityAvailableTerritoriesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAvailabilityAvailableTerritoriesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                InAppPurchaseAvailabilityAvailableTerritoriesLinkagesResponseDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAvailabilityAvailableTerritoriesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => InAppPurchaseAvailabilityAvailableTerritoriesLinkagesResponseDataItemType.Territories,
                _ => null,
            };
        }
    }
}