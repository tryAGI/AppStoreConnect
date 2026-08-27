
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionVersionImageLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionVersionImageLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionImageLinkageResponseDataType value)
        {
            return value switch
            {
                SubscriptionVersionImageLinkageResponseDataType.SubscriptionImages => "subscriptionImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionImageLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionImages" => SubscriptionVersionImageLinkageResponseDataType.SubscriptionImages,
                _ => null,
            };
        }
    }
}