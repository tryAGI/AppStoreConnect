
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibrariesImagesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Placements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibrariesImagesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibrariesImagesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppAssetLibrariesImagesGetToManyRelatedIncludeItem.Placements => "placements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibrariesImagesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "placements" => AppAssetLibrariesImagesGetToManyRelatedIncludeItem.Placements,
                _ => null,
            };
        }
    }
}