
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryMediaType
    {
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryMediaType value)
        {
            return value switch
            {
                AppAssetLibraryMediaType.Image => "IMAGE",
                AppAssetLibraryMediaType.Video => "VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryMediaType? ToEnum(string value)
        {
            return value switch
            {
                "IMAGE" => AppAssetLibraryMediaType.Image,
                "VIDEO" => AppAssetLibraryMediaType.Video,
                _ => null,
            };
        }
    }
}