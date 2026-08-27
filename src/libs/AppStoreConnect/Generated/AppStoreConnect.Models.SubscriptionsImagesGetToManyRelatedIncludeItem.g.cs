
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsImagesGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsImagesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsImagesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsImagesGetToManyRelatedIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsImagesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscription" => SubscriptionsImagesGetToManyRelatedIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}