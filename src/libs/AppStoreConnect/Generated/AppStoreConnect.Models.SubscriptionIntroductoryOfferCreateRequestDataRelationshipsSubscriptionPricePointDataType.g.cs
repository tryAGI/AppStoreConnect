
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionIntroductoryOfferCreateRequestDataRelationshipsSubscriptionPricePointDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionIntroductoryOfferCreateRequestDataRelationshipsSubscriptionPricePointDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionIntroductoryOfferCreateRequestDataRelationshipsSubscriptionPricePointDataType value)
        {
            return value switch
            {
                SubscriptionIntroductoryOfferCreateRequestDataRelationshipsSubscriptionPricePointDataType.SubscriptionPricePoints => "subscriptionPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionIntroductoryOfferCreateRequestDataRelationshipsSubscriptionPricePointDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => SubscriptionIntroductoryOfferCreateRequestDataRelationshipsSubscriptionPricePointDataType.SubscriptionPricePoints,
                _ => null,
            };
        }
    }
}