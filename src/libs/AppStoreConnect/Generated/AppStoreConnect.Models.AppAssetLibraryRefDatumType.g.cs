
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryRefDatumType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryRefData,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryRefDatumTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryRefDatumType value)
        {
            return value switch
            {
                AppAssetLibraryRefDatumType.AppAssetLibraryRefData => "appAssetLibraryRefData",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryRefDatumType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryRefData" => AppAssetLibraryRefDatumType.AppAssetLibraryRefData,
                _ => null,
            };
        }
    }
}