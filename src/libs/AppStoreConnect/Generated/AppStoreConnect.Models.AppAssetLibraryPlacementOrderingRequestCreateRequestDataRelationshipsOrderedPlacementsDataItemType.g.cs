
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryPlacements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemType.AppAssetLibraryPlacements => "appAssetLibraryPlacements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacements" => AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemType.AppAssetLibraryPlacements,
                _ => null,
            };
        }
    }
}