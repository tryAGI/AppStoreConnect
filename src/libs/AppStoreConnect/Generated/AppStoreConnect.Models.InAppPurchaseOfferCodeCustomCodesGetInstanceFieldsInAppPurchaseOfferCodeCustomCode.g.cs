
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode
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
    public static class InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.Active => "active",
                InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.CreatedByActor => "createdByActor",
                InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.CreatedDate => "createdDate",
                InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.CustomCode => "customCode",
                InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.DeactivatedByActor => "deactivatedByActor",
                InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.ExpirationDate => "expirationDate",
                InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.NumberOfCodes => "numberOfCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.Active,
                "createdByActor" => InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.CreatedByActor,
                "createdDate" => InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.CreatedDate,
                "customCode" => InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.CustomCode,
                "deactivatedByActor" => InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.DeactivatedByActor,
                "expirationDate" => InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.ExpirationDate,
                "numberOfCodes" => InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsInAppPurchaseOfferCodeCustomCode.NumberOfCodes,
                _ => null,
            };
        }
    }
}