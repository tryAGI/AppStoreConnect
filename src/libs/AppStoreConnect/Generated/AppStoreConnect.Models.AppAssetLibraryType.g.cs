
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraries,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryType value)
        {
            return value switch
            {
                AppAssetLibraryType.AppAssetLibraries => "appAssetLibraries",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraries" => AppAssetLibraryType.AppAssetLibraries,
                _ => null,
            };
        }
    }
}