
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BetaAppLocalizationsGetInstanceIncludeItem.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaAppLocalizationsGetInstanceIncludeItem.App,
                _ => null,
            };
        }
    }
}