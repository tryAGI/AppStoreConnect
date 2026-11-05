
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionUpdateRequestDataRelationshipsRetentionMessageOffersDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionUpdateRequestDataRelationshipsRetentionMessageOffersDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionUpdateRequestDataRelationshipsRetentionMessageOffersDataItemType value)
        {
            return value switch
            {
                SubscriptionUpdateRequestDataRelationshipsRetentionMessageOffersDataItemType.RetentionOffers => "retentionOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionUpdateRequestDataRelationshipsRetentionMessageOffersDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOffers" => SubscriptionUpdateRequestDataRelationshipsRetentionMessageOffersDataItemType.RetentionOffers,
                _ => null,
            };
        }
    }
}