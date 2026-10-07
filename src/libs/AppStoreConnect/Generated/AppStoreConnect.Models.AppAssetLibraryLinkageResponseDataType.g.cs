
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraries,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryLinkageResponseDataType value)
        {
            return value switch
            {
                AppAssetLibraryLinkageResponseDataType.AppAssetLibraries => "appAssetLibraries",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraries" => AppAssetLibraryLinkageResponseDataType.AppAssetLibraries,
                _ => null,
            };
        }
    }
}