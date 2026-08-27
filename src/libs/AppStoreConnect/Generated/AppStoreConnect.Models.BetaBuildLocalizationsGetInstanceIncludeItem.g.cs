
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaBuildLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Build,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBuildLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBuildLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BetaBuildLocalizationsGetInstanceIncludeItem.Build => "build",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBuildLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "build" => BetaBuildLocalizationsGetInstanceIncludeItem.Build,
                _ => null,
            };
        }
    }
}