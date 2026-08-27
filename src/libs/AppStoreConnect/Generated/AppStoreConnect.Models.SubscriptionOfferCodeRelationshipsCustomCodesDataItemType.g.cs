
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodeRelationshipsCustomCodesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionOfferCodeCustomCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeRelationshipsCustomCodesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeRelationshipsCustomCodesDataItemType value)
        {
            return value switch
            {
                SubscriptionOfferCodeRelationshipsCustomCodesDataItemType.SubscriptionOfferCodeCustomCodes => "subscriptionOfferCodeCustomCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeRelationshipsCustomCodesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodeCustomCodes" => SubscriptionOfferCodeRelationshipsCustomCodesDataItemType.SubscriptionOfferCodeCustomCodes,
                _ => null,
            };
        }
    }
}