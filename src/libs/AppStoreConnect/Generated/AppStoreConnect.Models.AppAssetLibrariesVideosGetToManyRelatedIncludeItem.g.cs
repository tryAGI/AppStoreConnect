
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibrariesVideosGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Placements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibrariesVideosGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibrariesVideosGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppAssetLibrariesVideosGetToManyRelatedIncludeItem.Placements => "placements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibrariesVideosGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "placements" => AppAssetLibrariesVideosGetToManyRelatedIncludeItem.Placements,
                _ => null,
            };
        }
    }
}