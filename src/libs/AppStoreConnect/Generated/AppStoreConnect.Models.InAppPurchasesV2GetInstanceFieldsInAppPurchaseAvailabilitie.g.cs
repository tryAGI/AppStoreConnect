
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie
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
    public static class InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie value)
        {
            return value switch
            {
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie.AvailableTerritories,
                _ => null,
            };
        }
    }
}