
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        CreatedDate,
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
        OfferCode,
        /// <summary>
        /// 
        /// </summary>
        Values,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode value)
        {
            return value switch
            {
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.Active => "active",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.CreatedDate => "createdDate",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.Environment => "environment",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.ExpirationDate => "expirationDate",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.NumberOfCodes => "numberOfCodes",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.OfferCode => "offerCode",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.Values => "values",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.Active,
                "createdDate" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.CreatedDate,
                "environment" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.Environment,
                "expirationDate" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.ExpirationDate,
                "numberOfCodes" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.NumberOfCodes,
                "offerCode" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.OfferCode,
                "values" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.Values,
                _ => null,
            };
        }
    }
}