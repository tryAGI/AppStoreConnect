
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsVersionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Images,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsVersionsGetToManyRelatedIncludeItem.Image => "image",
                SubscriptionsVersionsGetToManyRelatedIncludeItem.Images => "images",
                SubscriptionsVersionsGetToManyRelatedIncludeItem.Localizations => "localizations",
                SubscriptionsVersionsGetToManyRelatedIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => SubscriptionsVersionsGetToManyRelatedIncludeItem.Image,
                "images" => SubscriptionsVersionsGetToManyRelatedIncludeItem.Images,
                "localizations" => SubscriptionsVersionsGetToManyRelatedIncludeItem.Localizations,
                "subscription" => SubscriptionsVersionsGetToManyRelatedIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}