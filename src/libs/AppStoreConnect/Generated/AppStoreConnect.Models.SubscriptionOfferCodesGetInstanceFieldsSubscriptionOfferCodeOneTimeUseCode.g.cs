
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode
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
    public static class SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode value)
        {
            return value switch
            {
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.Active => "active",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.CreatedDate => "createdDate",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.Environment => "environment",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.ExpirationDate => "expirationDate",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.NumberOfCodes => "numberOfCodes",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.OfferCode => "offerCode",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.Values => "values",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.Active,
                "createdDate" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.CreatedDate,
                "environment" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.Environment,
                "expirationDate" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.ExpirationDate,
                "numberOfCodes" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.NumberOfCodes,
                "offerCode" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.OfferCode,
                "values" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeOneTimeUseCode.Values,
                _ => null,
            };
        }
    }
}