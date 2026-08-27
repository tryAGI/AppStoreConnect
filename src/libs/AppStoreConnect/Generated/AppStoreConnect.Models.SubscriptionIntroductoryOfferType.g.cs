
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionIntroductoryOfferType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionIntroductoryOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionIntroductoryOfferTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionIntroductoryOfferType value)
        {
            return value switch
            {
                SubscriptionIntroductoryOfferType.SubscriptionIntroductoryOffers => "subscriptionIntroductoryOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionIntroductoryOfferType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionIntroductoryOffers" => SubscriptionIntroductoryOfferType.SubscriptionIntroductoryOffers,
                _ => null,
            };
        }
    }
}