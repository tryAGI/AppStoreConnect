
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryPlacements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementType.AppAssetLibraryPlacements => "appAssetLibraryPlacements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacements" => AppAssetLibraryPlacementType.AppAssetLibraryPlacements,
                _ => null,
            };
        }
    }
}