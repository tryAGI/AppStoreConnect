
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionIntroductoryOffersLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionIntroductoryOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionIntroductoryOffersLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionIntroductoryOffersLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionIntroductoryOffersLinkagesResponseDataItemType.SubscriptionIntroductoryOffers => "subscriptionIntroductoryOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionIntroductoryOffersLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionIntroductoryOffers" => SubscriptionIntroductoryOffersLinkagesResponseDataItemType.SubscriptionIntroductoryOffers,
                _ => null,
            };
        }
    }
}