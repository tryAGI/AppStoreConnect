
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionVersionsGetInstanceIncludeItem
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
    public static class SubscriptionVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionVersionsGetInstanceIncludeItem.Image => "image",
                SubscriptionVersionsGetInstanceIncludeItem.Images => "images",
                SubscriptionVersionsGetInstanceIncludeItem.Localizations => "localizations",
                SubscriptionVersionsGetInstanceIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => SubscriptionVersionsGetInstanceIncludeItem.Image,
                "images" => SubscriptionVersionsGetInstanceIncludeItem.Images,
                "localizations" => SubscriptionVersionsGetInstanceIncludeItem.Localizations,
                "subscription" => SubscriptionVersionsGetInstanceIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}