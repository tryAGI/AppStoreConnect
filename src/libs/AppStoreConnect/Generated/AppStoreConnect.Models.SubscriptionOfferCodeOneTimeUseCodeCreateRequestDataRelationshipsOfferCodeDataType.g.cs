
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCodeDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionOfferCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCodeDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCodeDataType value)
        {
            return value switch
            {
                SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCodeDataType.SubscriptionOfferCodes => "subscriptionOfferCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCodeDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodes" => SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCodeDataType.SubscriptionOfferCodes,
                _ => null,
            };
        }
    }
}