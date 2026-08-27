
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionVersionImagesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionVersionImagesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionImagesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionVersionImagesLinkagesResponseDataItemType.SubscriptionImages => "subscriptionImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionImagesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionImages" => SubscriptionVersionImagesLinkagesResponseDataItemType.SubscriptionImages,
                _ => null,
            };
        }
    }
}