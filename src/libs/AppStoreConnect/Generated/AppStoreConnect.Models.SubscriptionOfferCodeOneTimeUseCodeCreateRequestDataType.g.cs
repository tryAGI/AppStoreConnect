
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionOfferCodeOneTimeUseCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataType.SubscriptionOfferCodeOneTimeUseCodes => "subscriptionOfferCodeOneTimeUseCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodeOneTimeUseCodes" => SubscriptionOfferCodeOneTimeUseCodeCreateRequestDataType.SubscriptionOfferCodeOneTimeUseCodes,
                _ => null,
            };
        }
    }
}