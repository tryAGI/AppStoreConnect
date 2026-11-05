
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOfferCreateRequestDataRelationshipsSubscriptionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOfferCreateRequestDataRelationshipsSubscriptionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOfferCreateRequestDataRelationshipsSubscriptionDataType value)
        {
            return value switch
            {
                RetentionOfferCreateRequestDataRelationshipsSubscriptionDataType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOfferCreateRequestDataRelationshipsSubscriptionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => RetentionOfferCreateRequestDataRelationshipsSubscriptionDataType.Subscriptions,
                _ => null,
            };
        }
    }
}