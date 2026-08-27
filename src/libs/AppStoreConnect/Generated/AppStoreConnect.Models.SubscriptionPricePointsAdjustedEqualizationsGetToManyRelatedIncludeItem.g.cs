
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "territory" => SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}