
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPricePointsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPricePointsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPricePointsGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionPricePointsGetInstanceIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPricePointsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "territory" => SubscriptionPricePointsGetInstanceIncludeItem.Territory,
                _ => null,
            };
        }
    }
}