
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataType value)
        {
            return value switch
            {
                SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataType.SubscriptionPricePoints => "subscriptionPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoints" => SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionPricePointDataType.SubscriptionPricePoints,
                _ => null,
            };
        }
    }
}