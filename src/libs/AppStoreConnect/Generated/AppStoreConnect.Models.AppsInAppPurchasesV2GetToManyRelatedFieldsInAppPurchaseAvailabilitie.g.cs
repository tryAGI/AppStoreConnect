
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie
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
    public static class AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie.AvailableTerritories,
                _ => null,
            };
        }
    }
}