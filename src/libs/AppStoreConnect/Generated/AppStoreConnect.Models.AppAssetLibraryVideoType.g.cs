
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideoType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryVideos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryVideoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideoType value)
        {
            return value switch
            {
                AppAssetLibraryVideoType.AppAssetLibraryVideos => "appAssetLibraryVideos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideoType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryVideos" => AppAssetLibraryVideoType.AppAssetLibraryVideos,
                _ => null,
            };
        }
    }
}