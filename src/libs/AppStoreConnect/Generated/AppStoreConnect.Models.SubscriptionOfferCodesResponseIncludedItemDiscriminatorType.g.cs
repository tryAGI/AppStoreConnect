
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodesResponseIncludedItemDiscriminatorType
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
    public static class SubscriptionOfferCodesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionOfferCodesResponseIncludedItemDiscriminatorType.SubscriptionOfferCodeCustomCodes => "subscriptionOfferCodeCustomCodes",
                SubscriptionOfferCodesResponseIncludedItemDiscriminatorType.SubscriptionOfferCodeOneTimeUseCodes => "subscriptionOfferCodeOneTimeUseCodes",
                SubscriptionOfferCodesResponseIncludedItemDiscriminatorType.SubscriptionOfferCodePrices => "subscriptionOfferCodePrices",
                SubscriptionOfferCodesResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodeCustomCodes" => SubscriptionOfferCodesResponseIncludedItemDiscriminatorType.SubscriptionOfferCodeCustomCodes,
                "subscriptionOfferCodeOneTimeUseCodes" => SubscriptionOfferCodesResponseIncludedItemDiscriminatorType.SubscriptionOfferCodeOneTimeUseCodes,
                "subscriptionOfferCodePrices" => SubscriptionOfferCodesResponseIncludedItemDiscriminatorType.SubscriptionOfferCodePrices,
                "subscriptions" => SubscriptionOfferCodesResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}