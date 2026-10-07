
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryPlacements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemType.AppAssetLibraryPlacements => "appAssetLibraryPlacements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacements" => AppStoreVersionLocalizationCreateRequestDataRelationshipsPlacementsDataItemType.AppAssetLibraryPlacements,
                _ => null,
            };
        }
    }
}