
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryPlacements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemType.AppAssetLibraryPlacements => "appAssetLibraryPlacements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacements" => AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemType.AppAssetLibraryPlacements,
                _ => null,
            };
        }
    }
}