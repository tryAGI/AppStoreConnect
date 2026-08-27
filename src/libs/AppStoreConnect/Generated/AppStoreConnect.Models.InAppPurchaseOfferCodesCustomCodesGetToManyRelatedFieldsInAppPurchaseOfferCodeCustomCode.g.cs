
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode
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
    public static class InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.Active => "active",
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.CreatedByActor => "createdByActor",
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.CreatedDate => "createdDate",
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.CustomCode => "customCode",
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.DeactivatedByActor => "deactivatedByActor",
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.ExpirationDate => "expirationDate",
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.NumberOfCodes => "numberOfCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.Active,
                "createdByActor" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.CreatedByActor,
                "createdDate" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.CreatedDate,
                "customCode" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.CustomCode,
                "deactivatedByActor" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.DeactivatedByActor,
                "expirationDate" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.ExpirationDate,
                "numberOfCodes" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode.NumberOfCodes,
                _ => null,
            };
        }
    }
}