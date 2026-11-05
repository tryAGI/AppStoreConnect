
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionRelationshipsRetentionOffersDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRelationshipsRetentionOffersDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRelationshipsRetentionOffersDataItemType value)
        {
            return value switch
            {
                SubscriptionRelationshipsRetentionOffersDataItemType.RetentionOffers => "retentionOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRelationshipsRetentionOffersDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOffers" => SubscriptionRelationshipsRetentionOffersDataItemType.RetentionOffers,
                _ => null,
            };
        }
    }
}