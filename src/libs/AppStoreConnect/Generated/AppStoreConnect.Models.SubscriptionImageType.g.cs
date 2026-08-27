
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionImageType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionImageType value)
        {
            return value switch
            {
                SubscriptionImageType.SubscriptionImages => "subscriptionImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionImageType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionImages" => SubscriptionImageType.SubscriptionImages,
                _ => null,
            };
        }
    }
}