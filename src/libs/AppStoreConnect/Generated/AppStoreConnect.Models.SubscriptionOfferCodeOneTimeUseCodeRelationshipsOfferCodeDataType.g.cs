
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionOfferCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType value)
        {
            return value switch
            {
                SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType.SubscriptionOfferCodes => "subscriptionOfferCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodes" => SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType.SubscriptionOfferCodes,
                _ => null,
            };
        }
    }
}