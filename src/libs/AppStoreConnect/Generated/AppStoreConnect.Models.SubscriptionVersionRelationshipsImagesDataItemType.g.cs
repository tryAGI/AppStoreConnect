
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionVersionRelationshipsImagesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionVersionRelationshipsImagesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionRelationshipsImagesDataItemType value)
        {
            return value switch
            {
                SubscriptionVersionRelationshipsImagesDataItemType.SubscriptionImages => "subscriptionImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionRelationshipsImagesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionImages" => SubscriptionVersionRelationshipsImagesDataItemType.SubscriptionImages,
                _ => null,
            };
        }
    }
}