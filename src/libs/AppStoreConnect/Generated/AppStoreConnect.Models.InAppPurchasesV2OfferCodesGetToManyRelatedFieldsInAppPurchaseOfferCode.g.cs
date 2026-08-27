
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode
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
    public static class InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode value)
        {
            return value switch
            {
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.Active => "active",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.CustomCodes => "customCodes",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.CustomerEligibilities => "customerEligibilities",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.Name => "name",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.OneTimeUseCodes => "oneTimeUseCodes",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.Prices => "prices",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.ProductionCodeCount => "productionCodeCount",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.SandboxCodeCount => "sandboxCodeCount",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.Active,
                "customCodes" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.CustomCodes,
                "customerEligibilities" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.CustomerEligibilities,
                "name" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.Name,
                "oneTimeUseCodes" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.OneTimeUseCodes,
                "prices" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.Prices,
                "productionCodeCount" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.ProductionCodeCount,
                "sandboxCodeCount" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode.SandboxCodeCount,
                _ => null,
            };
        }
    }
}