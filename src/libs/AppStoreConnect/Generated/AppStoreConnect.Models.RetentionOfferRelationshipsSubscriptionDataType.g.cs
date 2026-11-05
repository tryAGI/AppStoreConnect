
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOfferRelationshipsSubscriptionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOfferRelationshipsSubscriptionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOfferRelationshipsSubscriptionDataType value)
        {
            return value switch
            {
                RetentionOfferRelationshipsSubscriptionDataType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOfferRelationshipsSubscriptionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => RetentionOfferRelationshipsSubscriptionDataType.Subscriptions,
                _ => null,
            };
        }
    }
}