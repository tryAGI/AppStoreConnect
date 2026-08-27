
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode
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
    public static class InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.Active => "active",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.CreatedByActor => "createdByActor",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.CreatedDate => "createdDate",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.CustomCode => "customCode",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.DeactivatedByActor => "deactivatedByActor",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.ExpirationDate => "expirationDate",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.NumberOfCodes => "numberOfCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.Active,
                "createdByActor" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.CreatedByActor,
                "createdDate" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.CreatedDate,
                "customCode" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.CustomCode,
                "deactivatedByActor" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.DeactivatedByActor,
                "expirationDate" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.ExpirationDate,
                "numberOfCodes" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.NumberOfCodes,
                _ => null,
            };
        }
    }
}