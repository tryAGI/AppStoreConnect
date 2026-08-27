
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionRelationshipsImagesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRelationshipsImagesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRelationshipsImagesDataItemType value)
        {
            return value switch
            {
                SubscriptionRelationshipsImagesDataItemType.SubscriptionImages => "subscriptionImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRelationshipsImagesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionImages" => SubscriptionRelationshipsImagesDataItemType.SubscriptionImages,
                _ => null,
            };
        }
    }
}