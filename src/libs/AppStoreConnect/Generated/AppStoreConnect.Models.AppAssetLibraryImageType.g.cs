
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImageType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImageType value)
        {
            return value switch
            {
                AppAssetLibraryImageType.AppAssetLibraryImages => "appAssetLibraryImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImageType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryImages" => AppAssetLibraryImageType.AppAssetLibraryImages,
                _ => null,
            };
        }
    }
}