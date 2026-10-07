
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibrariesGetInstanceFieldsAppAssetLibrarie
    {
        /// <summary>
        ///
        /// </summary>
        Images,
        /// <summary>
        ///
        /// </summary>
        Videos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibrariesGetInstanceFieldsAppAssetLibrarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibrariesGetInstanceFieldsAppAssetLibrarie value)
        {
            return value switch
            {
                AppAssetLibrariesGetInstanceFieldsAppAssetLibrarie.Images => "images",
                AppAssetLibrariesGetInstanceFieldsAppAssetLibrarie.Videos => "videos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibrariesGetInstanceFieldsAppAssetLibrarie? ToEnum(string value)
        {
            return value switch
            {
                "images" => AppAssetLibrariesGetInstanceFieldsAppAssetLibrarie.Images,
                "videos" => AppAssetLibrariesGetInstanceFieldsAppAssetLibrarie.Videos,
                _ => null,
            };
        }
    }
}