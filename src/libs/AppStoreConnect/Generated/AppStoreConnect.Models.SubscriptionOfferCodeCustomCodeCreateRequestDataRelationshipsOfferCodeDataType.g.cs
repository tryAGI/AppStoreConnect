
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionOfferCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType value)
        {
            return value switch
            {
                SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType.SubscriptionOfferCodes => "subscriptionOfferCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodes" => SubscriptionOfferCodeCustomCodeCreateRequestDataRelationshipsOfferCodeDataType.SubscriptionOfferCodes,
                _ => null,
            };
        }
    }
}