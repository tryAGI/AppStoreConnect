
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseAvailabilitiesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AvailableTerritories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAvailabilitiesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAvailabilitiesGetInstanceIncludeItem value)
        {
            return value switch
            {
                InAppPurchaseAvailabilitiesGetInstanceIncludeItem.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAvailabilitiesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "availableTerritories" => InAppPurchaseAvailabilitiesGetInstanceIncludeItem.AvailableTerritories,
                _ => null,
            };
        }
    }
}