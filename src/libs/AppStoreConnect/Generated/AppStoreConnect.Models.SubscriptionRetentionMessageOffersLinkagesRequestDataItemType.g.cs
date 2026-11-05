
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionRetentionMessageOffersLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRetentionMessageOffersLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRetentionMessageOffersLinkagesRequestDataItemType value)
        {
            return value switch
            {
                SubscriptionRetentionMessageOffersLinkagesRequestDataItemType.RetentionOffers => "retentionOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRetentionMessageOffersLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOffers" => SubscriptionRetentionMessageOffersLinkagesRequestDataItemType.RetentionOffers,
                _ => null,
            };
        }
    }
}