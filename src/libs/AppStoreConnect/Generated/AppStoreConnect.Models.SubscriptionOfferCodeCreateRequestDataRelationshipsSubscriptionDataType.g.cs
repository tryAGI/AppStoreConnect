
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeCreateRequestDataRelationshipsSubscriptionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeCreateRequestDataRelationshipsSubscriptionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeCreateRequestDataRelationshipsSubscriptionDataType value)
        {
            return value switch
            {
                SubscriptionOfferCodeCreateRequestDataRelationshipsSubscriptionDataType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeCreateRequestDataRelationshipsSubscriptionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => SubscriptionOfferCodeCreateRequestDataRelationshipsSubscriptionDataType.Subscriptions,
                _ => null,
            };
        }
    }
}