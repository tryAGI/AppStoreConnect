
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImageUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryImageUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImageUpdateRequestDataType value)
        {
            return value switch
            {
                AppAssetLibraryImageUpdateRequestDataType.AppAssetLibraryImages => "appAssetLibraryImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImageUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryImages" => AppAssetLibraryImageUpdateRequestDataType.AppAssetLibraryImages,
                _ => null,
            };
        }
    }
}