
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeOneTimeUseCodeUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionOfferCodeOneTimeUseCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeOneTimeUseCodeUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeOneTimeUseCodeUpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionOfferCodeOneTimeUseCodeUpdateRequestDataType.SubscriptionOfferCodeOneTimeUseCodes => "subscriptionOfferCodeOneTimeUseCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeOneTimeUseCodeUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodeOneTimeUseCodes" => SubscriptionOfferCodeOneTimeUseCodeUpdateRequestDataType.SubscriptionOfferCodeOneTimeUseCodes,
                _ => null,
            };
        }
    }
}