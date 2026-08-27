
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionIntroductoryOfferUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionIntroductoryOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionIntroductoryOfferUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionIntroductoryOfferUpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionIntroductoryOfferUpdateRequestDataType.SubscriptionIntroductoryOffers => "subscriptionIntroductoryOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionIntroductoryOfferUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionIntroductoryOffers" => SubscriptionIntroductoryOfferUpdateRequestDataType.SubscriptionIntroductoryOffers,
                _ => null,
            };
        }
    }
}