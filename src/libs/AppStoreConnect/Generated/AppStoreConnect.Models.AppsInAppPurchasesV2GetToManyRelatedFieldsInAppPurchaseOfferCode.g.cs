
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode
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
    public static class AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.Active => "active",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.CustomCodes => "customCodes",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.CustomerEligibilities => "customerEligibilities",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.Name => "name",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.OneTimeUseCodes => "oneTimeUseCodes",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.Prices => "prices",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.ProductionCodeCount => "productionCodeCount",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.SandboxCodeCount => "sandboxCodeCount",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.Active,
                "customCodes" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.CustomCodes,
                "customerEligibilities" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.CustomerEligibilities,
                "name" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.Name,
                "oneTimeUseCodes" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.OneTimeUseCodes,
                "prices" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.Prices,
                "productionCodeCount" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.ProductionCodeCount,
                "sandboxCodeCount" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode.SandboxCodeCount,
                _ => null,
            };
        }
    }
}