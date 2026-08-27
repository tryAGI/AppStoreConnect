
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodeResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionOfferCodeCustomCodes,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionOfferCodeOneTimeUseCodes,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionOfferCodePrices,
        /// <summary>
        /// 
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionOfferCodeResponseIncludedItemDiscriminatorType.SubscriptionOfferCodeCustomCodes => "subscriptionOfferCodeCustomCodes",
                SubscriptionOfferCodeResponseIncludedItemDiscriminatorType.SubscriptionOfferCodeOneTimeUseCodes => "subscriptionOfferCodeOneTimeUseCodes",
                SubscriptionOfferCodeResponseIncludedItemDiscriminatorType.SubscriptionOfferCodePrices => "subscriptionOfferCodePrices",
                SubscriptionOfferCodeResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodeCustomCodes" => SubscriptionOfferCodeResponseIncludedItemDiscriminatorType.SubscriptionOfferCodeCustomCodes,
                "subscriptionOfferCodeOneTimeUseCodes" => SubscriptionOfferCodeResponseIncludedItemDiscriminatorType.SubscriptionOfferCodeOneTimeUseCodes,
                "subscriptionOfferCodePrices" => SubscriptionOfferCodeResponseIncludedItemDiscriminatorType.SubscriptionOfferCodePrices,
                "subscriptions" => SubscriptionOfferCodeResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}