
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionImagesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionImagesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionImagesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionImagesLinkagesResponseDataItemType.SubscriptionImages => "subscriptionImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionImagesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionImages" => SubscriptionImagesLinkagesResponseDataItemType.SubscriptionImages,
                _ => null,
            };
        }
    }
}