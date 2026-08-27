
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionImageUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionImageUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionImageUpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionImageUpdateRequestDataType.SubscriptionImages => "subscriptionImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionImageUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionImages" => SubscriptionImageUpdateRequestDataType.SubscriptionImages,
                _ => null,
            };
        }
    }
}