
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionRelationshipsPromotionalOffersDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPromotionalOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRelationshipsPromotionalOffersDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRelationshipsPromotionalOffersDataItemType value)
        {
            return value switch
            {
                SubscriptionRelationshipsPromotionalOffersDataItemType.SubscriptionPromotionalOffers => "subscriptionPromotionalOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRelationshipsPromotionalOffersDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPromotionalOffers" => SubscriptionRelationshipsPromotionalOffersDataItemType.SubscriptionPromotionalOffers,
                _ => null,
            };
        }
    }
}