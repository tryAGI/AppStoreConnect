
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationRelationshipsPlacementsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryPlacements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationRelationshipsPlacementsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationRelationshipsPlacementsDataItemType value)
        {
            return value switch
            {
                AppEventLocalizationRelationshipsPlacementsDataItemType.AppAssetLibraryPlacements => "appAssetLibraryPlacements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationRelationshipsPlacementsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacements" => AppEventLocalizationRelationshipsPlacementsDataItemType.AppAssetLibraryPlacements,
                _ => null,
            };
        }
    }
}