
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionImageCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionImageCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionImageCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionImageCreateRequestDataType.SubscriptionImages => "subscriptionImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionImageCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionImages" => SubscriptionImageCreateRequestDataType.SubscriptionImages,
                _ => null,
            };
        }
    }
}