
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsWinBackOffersGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Prices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsWinBackOffersGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsWinBackOffersGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsWinBackOffersGetToManyRelatedIncludeItem.Prices => "prices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsWinBackOffersGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "prices" => SubscriptionsWinBackOffersGetToManyRelatedIncludeItem.Prices,
                _ => null,
            };
        }
    }
}