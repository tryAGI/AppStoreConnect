
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WinBackOffersGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Prices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WinBackOffersGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOffersGetInstanceIncludeItem value)
        {
            return value switch
            {
                WinBackOffersGetInstanceIncludeItem.Prices => "prices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOffersGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "prices" => WinBackOffersGetInstanceIncludeItem.Prices,
                _ => null,
            };
        }
    }
}