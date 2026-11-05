
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionRelationshipsRetentionMessageOffersDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRelationshipsRetentionMessageOffersDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRelationshipsRetentionMessageOffersDataItemType value)
        {
            return value switch
            {
                SubscriptionRelationshipsRetentionMessageOffersDataItemType.RetentionOffers => "retentionOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRelationshipsRetentionMessageOffersDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOffers" => SubscriptionRelationshipsRetentionMessageOffersDataItemType.RetentionOffers,
                _ => null,
            };
        }
    }
}