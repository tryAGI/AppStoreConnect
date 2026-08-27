
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeOneTimeUseCodeValueType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionOfferCodeOneTimeUseCodeValues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeOneTimeUseCodeValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeOneTimeUseCodeValueType value)
        {
            return value switch
            {
                SubscriptionOfferCodeOneTimeUseCodeValueType.SubscriptionOfferCodeOneTimeUseCodeValues => "subscriptionOfferCodeOneTimeUseCodeValues",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeOneTimeUseCodeValueType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodeOneTimeUseCodeValues" => SubscriptionOfferCodeOneTimeUseCodeValueType.SubscriptionOfferCodeOneTimeUseCodeValues,
                _ => null,
            };
        }
    }
}