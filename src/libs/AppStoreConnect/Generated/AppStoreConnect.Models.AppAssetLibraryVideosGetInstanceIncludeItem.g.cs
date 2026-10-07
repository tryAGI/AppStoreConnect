
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideosGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Placements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryVideosGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideosGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppAssetLibraryVideosGetInstanceIncludeItem.Placements => "placements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideosGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "placements" => AppAssetLibraryVideosGetInstanceIncludeItem.Placements,
                _ => null,
            };
        }
    }
}