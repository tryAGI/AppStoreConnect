
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsPricePointsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsPricePointsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsPricePointsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsPricePointsGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsPricePointsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "territory" => SubscriptionsPricePointsGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}