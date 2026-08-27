
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionRelationshipsIntroductoryOffersDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionIntroductoryOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRelationshipsIntroductoryOffersDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRelationshipsIntroductoryOffersDataItemType value)
        {
            return value switch
            {
                SubscriptionRelationshipsIntroductoryOffersDataItemType.SubscriptionIntroductoryOffers => "subscriptionIntroductoryOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRelationshipsIntroductoryOffersDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionIntroductoryOffers" => SubscriptionRelationshipsIntroductoryOffersDataItemType.SubscriptionIntroductoryOffers,
                _ => null,
            };
        }
    }
}