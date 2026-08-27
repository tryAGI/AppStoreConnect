
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPagesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPagesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPagesGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppCustomProductPagesGetInstanceIncludeItem.App => "app",
                AppCustomProductPagesGetInstanceIncludeItem.AppCustomProductPageVersions => "appCustomProductPageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPagesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppCustomProductPagesGetInstanceIncludeItem.App,
                "appCustomProductPageVersions" => AppCustomProductPagesGetInstanceIncludeItem.AppCustomProductPageVersions,
                _ => null,
            };
        }
    }
}