
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionImageV2UpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionImageV2UpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionImageV2UpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionImageV2UpdateRequestDataType.SubscriptionImages => "subscriptionImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionImageV2UpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionImages" => SubscriptionImageV2UpdateRequestDataType.SubscriptionImages,
                _ => null,
            };
        }
    }
}