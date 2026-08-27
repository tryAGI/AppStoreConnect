
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode
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
        CustomCode,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode value)
        {
            return value switch
            {
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode.Active => "active",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode.CreatedDate => "createdDate",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode.CustomCode => "customCode",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode.ExpirationDate => "expirationDate",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode.NumberOfCodes => "numberOfCodes",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode.OfferCode => "offerCode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode.Active,
                "createdDate" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode.CreatedDate,
                "customCode" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode.CustomCode,
                "expirationDate" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode.ExpirationDate,
                "numberOfCodes" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode.NumberOfCodes,
                "offerCode" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode.OfferCode,
                _ => null,
            };
        }
    }
}