
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionOfferCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType value)
        {
            return value switch
            {
                SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType.SubscriptionOfferCodes => "subscriptionOfferCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodes" => SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType.SubscriptionOfferCodes,
                _ => null,
            };
        }
    }
}