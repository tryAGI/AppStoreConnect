
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOfferPriceRelationshipsSubscriptionPricePointDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOfferPriceRelationshipsSubscriptionPricePointDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOfferPriceRelationshipsSubscriptionPricePointDataType value)
        {
            return value switch
            {
                RetentionOfferPriceRelationshipsSubscriptionPricePointDataType.SubscriptionPricePoints => "subscriptionPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOfferPriceRelationshipsSubscriptionPricePointDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => RetentionOfferPriceRelationshipsSubscriptionPricePointDataType.SubscriptionPricePoints,
                _ => null,
            };
        }
    }
}