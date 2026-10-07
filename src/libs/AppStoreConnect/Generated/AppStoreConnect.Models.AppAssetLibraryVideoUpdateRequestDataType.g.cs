
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideoUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryVideos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryVideoUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideoUpdateRequestDataType value)
        {
            return value switch
            {
                AppAssetLibraryVideoUpdateRequestDataType.AppAssetLibraryVideos => "appAssetLibraryVideos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideoUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryVideos" => AppAssetLibraryVideoUpdateRequestDataType.AppAssetLibraryVideos,
                _ => null,
            };
        }
    }
}