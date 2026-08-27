
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionImageV2Type
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionImageV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionImageV2Type value)
        {
            return value switch
            {
                SubscriptionImageV2Type.SubscriptionImages => "subscriptionImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionImageV2Type? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionImages" => SubscriptionImageV2Type.SubscriptionImages,
                _ => null,
            };
        }
    }
}