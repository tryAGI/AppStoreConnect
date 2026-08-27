
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        CustomCodes,
        /// <summary>
        ///
        /// </summary>
        CustomerEligibilities,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        OneTimeUseCodes,
        /// <summary>
        ///
        /// </summary>
        Prices,
        /// <summary>
        ///
        /// </summary>
        ProductionCodeCount,
        /// <summary>
        ///
        /// </summary>
        SandboxCodeCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode value)
        {
            return value switch
            {
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.Active => "active",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.CustomCodes => "customCodes",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.CustomerEligibilities => "customerEligibilities",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.Name => "name",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.OneTimeUseCodes => "oneTimeUseCodes",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.Prices => "prices",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.ProductionCodeCount => "productionCodeCount",
                InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.SandboxCodeCount => "sandboxCodeCount",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.Active,
                "customCodes" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.CustomCodes,
                "customerEligibilities" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.CustomerEligibilities,
                "name" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.Name,
                "oneTimeUseCodes" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.OneTimeUseCodes,
                "prices" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.Prices,
                "productionCodeCount" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.ProductionCodeCount,
                "sandboxCodeCount" => InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode.SandboxCodeCount,
                _ => null,
            };
        }
    }
}