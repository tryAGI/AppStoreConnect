
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode
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
    public static class SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode value)
        {
            return value switch
            {
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.Active => "active",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.CreatedDate => "createdDate",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.CustomCode => "customCode",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.ExpirationDate => "expirationDate",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.NumberOfCodes => "numberOfCodes",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.OfferCode => "offerCode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.Active,
                "createdDate" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.CreatedDate,
                "customCode" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.CustomCode,
                "expirationDate" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.ExpirationDate,
                "numberOfCodes" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.NumberOfCodes,
                "offerCode" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.OfferCode,
                _ => null,
            };
        }
    }
}