
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode
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
    public static class InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.Active => "active",
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedByActor => "createdByActor",
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedDate => "createdDate",
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.DeactivatedByActor => "deactivatedByActor",
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.Environment => "environment",
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.ExpirationDate => "expirationDate",
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.NumberOfCodes => "numberOfCodes",
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.Values => "values",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.Active,
                "createdByActor" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedByActor,
                "createdDate" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.CreatedDate,
                "deactivatedByActor" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.DeactivatedByActor,
                "environment" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.Environment,
                "expirationDate" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.ExpirationDate,
                "numberOfCodes" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.NumberOfCodes,
                "values" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsInAppPurchaseOfferCodeOneTimeUseCode.Values,
                _ => null,
            };
        }
    }
}