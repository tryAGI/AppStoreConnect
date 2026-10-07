
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImagesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Placements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryImagesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImagesGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppAssetLibraryImagesGetInstanceIncludeItem.Placements => "placements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImagesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "placements" => AppAssetLibraryImagesGetInstanceIncludeItem.Placements,
                _ => null,
            };
        }
    }
}