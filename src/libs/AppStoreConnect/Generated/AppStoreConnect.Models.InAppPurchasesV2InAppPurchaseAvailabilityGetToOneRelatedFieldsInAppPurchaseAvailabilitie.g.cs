
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsInAppPurchaseAvailabilitie
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
    public static class InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsInAppPurchaseAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsInAppPurchaseAvailabilitie value)
        {
            return value switch
            {
                InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsInAppPurchaseAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsInAppPurchaseAvailabilitie.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsInAppPurchaseAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsInAppPurchaseAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedFieldsInAppPurchaseAvailabilitie.AvailableTerritories,
                _ => null,
            };
        }
    }
}