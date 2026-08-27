
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType
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
    public static class SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType.SubscriptionPricePoints => "subscriptionPricePoints",
                SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType.SubscriptionPricePoints,
                "subscriptions" => SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType.Subscriptions,
                "territories" => SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}