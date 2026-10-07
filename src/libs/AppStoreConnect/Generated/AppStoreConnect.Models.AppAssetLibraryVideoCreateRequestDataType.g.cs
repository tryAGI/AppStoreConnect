
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideoCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryVideos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryVideoCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideoCreateRequestDataType value)
        {
            return value switch
            {
                AppAssetLibraryVideoCreateRequestDataType.AppAssetLibraryVideos => "appAssetLibraryVideos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideoCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryVideos" => AppAssetLibraryVideoCreateRequestDataType.AppAssetLibraryVideos,
                _ => null,
            };
        }
    }
}