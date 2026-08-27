
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode
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
    public static class InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.Active => "active",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.CustomCodes => "customCodes",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.CustomerEligibilities => "customerEligibilities",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.Name => "name",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.OneTimeUseCodes => "oneTimeUseCodes",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.Prices => "prices",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.ProductionCodeCount => "productionCodeCount",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.SandboxCodeCount => "sandboxCodeCount",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.Active,
                "customCodes" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.CustomCodes,
                "customerEligibilities" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.CustomerEligibilities,
                "name" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.Name,
                "oneTimeUseCodes" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.OneTimeUseCodes,
                "prices" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.Prices,
                "productionCodeCount" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.ProductionCodeCount,
                "sandboxCodeCount" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCode.SandboxCodeCount,
                _ => null,
            };
        }
    }
}