
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionIntroductoryOfferResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPricePoints,
        /// <summary>
        /// 
        /// </summary>
        Subscriptions,
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionIntroductoryOfferResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionIntroductoryOfferResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionIntroductoryOfferResponseIncludedItemDiscriminatorType.SubscriptionPricePoints => "subscriptionPricePoints",
                SubscriptionIntroductoryOfferResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                SubscriptionIntroductoryOfferResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionIntroductoryOfferResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => SubscriptionIntroductoryOfferResponseIncludedItemDiscriminatorType.SubscriptionPricePoints,
                "subscriptions" => SubscriptionIntroductoryOfferResponseIncludedItemDiscriminatorType.Subscriptions,
                "territories" => SubscriptionIntroductoryOfferResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}