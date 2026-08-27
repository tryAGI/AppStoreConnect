
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode
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
    public static class SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode value)
        {
            return value switch
            {
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.Active => "active",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.CreatedDate => "createdDate",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.CustomCode => "customCode",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.ExpirationDate => "expirationDate",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.NumberOfCodes => "numberOfCodes",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.OfferCode => "offerCode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.Active,
                "createdDate" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.CreatedDate,
                "customCode" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.CustomCode,
                "expirationDate" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.ExpirationDate,
                "numberOfCodes" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.NumberOfCodes,
                "offerCode" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeCustomCode.OfferCode,
                _ => null,
            };
        }
    }
}