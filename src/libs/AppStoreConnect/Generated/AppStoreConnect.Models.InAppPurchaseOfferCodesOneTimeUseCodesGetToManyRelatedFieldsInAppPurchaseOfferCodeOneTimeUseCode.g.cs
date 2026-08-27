
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode
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
    public static class InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.Active => "active",
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedByActor => "createdByActor",
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedDate => "createdDate",
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.DeactivatedByActor => "deactivatedByActor",
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.Environment => "environment",
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.ExpirationDate => "expirationDate",
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.NumberOfCodes => "numberOfCodes",
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.Values => "values",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.Active,
                "createdByActor" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedByActor,
                "createdDate" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedDate,
                "deactivatedByActor" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.DeactivatedByActor,
                "environment" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.Environment,
                "expirationDate" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.ExpirationDate,
                "numberOfCodes" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.NumberOfCodes,
                "values" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode.Values,
                _ => null,
            };
        }
    }
}