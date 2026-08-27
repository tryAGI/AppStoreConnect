
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeOneTimeUseCodeValuesLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionOfferCodeOneTimeUseCodeValues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeOneTimeUseCodeValuesLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeOneTimeUseCodeValuesLinkageResponseDataType value)
        {
            return value switch
            {
                SubscriptionOfferCodeOneTimeUseCodeValuesLinkageResponseDataType.SubscriptionOfferCodeOneTimeUseCodeValues => "subscriptionOfferCodeOneTimeUseCodeValues",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeOneTimeUseCodeValuesLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodeOneTimeUseCodeValues" => SubscriptionOfferCodeOneTimeUseCodeValuesLinkageResponseDataType.SubscriptionOfferCodeOneTimeUseCodeValues,
                _ => null,
            };
        }
    }
}