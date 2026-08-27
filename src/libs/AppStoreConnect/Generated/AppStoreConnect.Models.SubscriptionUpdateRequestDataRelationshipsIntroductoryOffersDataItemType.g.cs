
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionIntroductoryOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemType value)
        {
            return value switch
            {
                SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemType.SubscriptionIntroductoryOffers => "subscriptionIntroductoryOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionIntroductoryOffers" => SubscriptionUpdateRequestDataRelationshipsIntroductoryOffersDataItemType.SubscriptionIntroductoryOffers,
                _ => null,
            };
        }
    }
}