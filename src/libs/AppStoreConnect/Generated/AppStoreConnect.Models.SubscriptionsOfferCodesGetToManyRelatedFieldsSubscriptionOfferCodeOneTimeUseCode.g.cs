
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode
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
    public static class SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode value)
        {
            return value switch
            {
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.Active => "active",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.CreatedDate => "createdDate",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.Environment => "environment",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.ExpirationDate => "expirationDate",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.NumberOfCodes => "numberOfCodes",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.OfferCode => "offerCode",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.Values => "values",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.Active,
                "createdDate" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.CreatedDate,
                "environment" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.Environment,
                "expirationDate" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.ExpirationDate,
                "numberOfCodes" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.NumberOfCodes,
                "offerCode" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.OfferCode,
                "values" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode.Values,
                _ => null,
            };
        }
    }
}