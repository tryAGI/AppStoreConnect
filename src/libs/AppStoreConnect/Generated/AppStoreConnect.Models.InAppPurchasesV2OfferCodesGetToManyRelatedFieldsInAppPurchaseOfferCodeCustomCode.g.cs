
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode
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
        CustomCode,
        /// <summary>
        ///
        /// </summary>
        DeactivatedByActor,
        /// <summary>
        ///
        /// </summary>
        ExpirationDate,
        /// <summary>
        ///
        /// </summary>
        NumberOfCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode value)
        {
            return value switch
            {
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.Active => "active",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.CreatedByActor => "createdByActor",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.CreatedDate => "createdDate",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.CustomCode => "customCode",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.DeactivatedByActor => "deactivatedByActor",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.ExpirationDate => "expirationDate",
                InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.NumberOfCodes => "numberOfCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.Active,
                "createdByActor" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.CreatedByActor,
                "createdDate" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.CreatedDate,
                "customCode" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.CustomCode,
                "deactivatedByActor" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.DeactivatedByActor,
                "expirationDate" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.ExpirationDate,
                "numberOfCodes" => InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.NumberOfCodes,
                _ => null,
            };
        }
    }
}