
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionRetentionOffersLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRetentionOffersLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRetentionOffersLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionRetentionOffersLinkagesResponseDataItemType.RetentionOffers => "retentionOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRetentionOffersLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOffers" => SubscriptionRetentionOffersLinkagesResponseDataItemType.RetentionOffers,
                _ => null,
            };
        }
    }
}