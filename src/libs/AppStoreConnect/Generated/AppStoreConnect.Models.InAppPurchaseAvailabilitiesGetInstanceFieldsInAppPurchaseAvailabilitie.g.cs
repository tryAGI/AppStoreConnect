
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie
    {
        /// <summary>
        /// 
        /// </summary>
        AvailableInNewTerritories,
        /// <summary>
        /// 
        /// </summary>
        AvailableTerritories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie value)
        {
            return value switch
            {
                InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie.AvailableTerritories,
                _ => null,
            };
        }
    }
}