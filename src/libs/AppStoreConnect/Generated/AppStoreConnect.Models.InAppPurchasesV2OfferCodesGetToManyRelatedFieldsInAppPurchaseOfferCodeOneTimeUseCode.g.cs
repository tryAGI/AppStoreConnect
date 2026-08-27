
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        CreatedByActor,
        /// <summary>
        /// 
        /// </summary>
        CreatedDate,
        /// <summary>
        /// 
        /// </summary>
        DeactivatedByActor,
        /// <summary>
        /// 
        /// </summary>
        Environment,
        /// <summary>
        /// 
        /// </summary>
        ExpirationDate,
        /// <summary>
        /// 
        /// </summary>
        NumberOfCodes,
        /// <summary>
        /// 
        /// </summary>
        Values,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode value)
        {
            return value switch
            {
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.Active => "active",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedByActor => "createdByActor",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedDate => "createdDate",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.DeactivatedByActor => "deactivatedByActor",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.Environment => "environment",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.ExpirationDate => "expirationDate",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.NumberOfCodes => "numberOfCodes",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.Values => "values",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.Active,
                "createdByActor" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedByActor,
                "createdDate" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedDate,
                "deactivatedByActor" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.DeactivatedByActor,
                "environment" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.Environment,
                "expirationDate" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.ExpirationDate,
                "numberOfCodes" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.NumberOfCodes,
                "values" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.Values,
                _ => null,
            };
        }
    }
}