
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode
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
    public static class InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.Active => "active",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedByActor => "createdByActor",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedDate => "createdDate",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.DeactivatedByActor => "deactivatedByActor",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.Environment => "environment",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.ExpirationDate => "expirationDate",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.NumberOfCodes => "numberOfCodes",
                InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.Values => "values",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.Active,
                "createdByActor" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedByActor,
                "createdDate" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedDate,
                "deactivatedByActor" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.DeactivatedByActor,
                "environment" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.Environment,
                "expirationDate" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.ExpirationDate,
                "numberOfCodes" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.NumberOfCodes,
                "values" => InAppPurchaseOfferCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.Values,
                _ => null,
            };
        }
    }
}