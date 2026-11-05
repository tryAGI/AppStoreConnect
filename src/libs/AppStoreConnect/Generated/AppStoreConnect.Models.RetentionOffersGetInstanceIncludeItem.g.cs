
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOffersGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Prices,
        /// <summary>
        ///
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOffersGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOffersGetInstanceIncludeItem value)
        {
            return value switch
            {
                RetentionOffersGetInstanceIncludeItem.Prices => "prices",
                RetentionOffersGetInstanceIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOffersGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "prices" => RetentionOffersGetInstanceIncludeItem.Prices,
                "subscription" => RetentionOffersGetInstanceIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}