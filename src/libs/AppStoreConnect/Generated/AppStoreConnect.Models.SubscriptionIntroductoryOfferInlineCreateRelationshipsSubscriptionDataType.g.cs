
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataType value)
        {
            return value switch
            {
                SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => SubscriptionIntroductoryOfferInlineCreateRelationshipsSubscriptionDataType.Subscriptions,
                _ => null,
            };
        }
    }
}