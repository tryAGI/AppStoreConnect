
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationCreateRequestDataRelationshipsPlacementsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryPlacements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationCreateRequestDataRelationshipsPlacementsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationCreateRequestDataRelationshipsPlacementsDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationCreateRequestDataRelationshipsPlacementsDataItemType.AppAssetLibraryPlacements => "appAssetLibraryPlacements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationCreateRequestDataRelationshipsPlacementsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacements" => AppCustomProductPageLocalizationCreateRequestDataRelationshipsPlacementsDataItemType.AppAssetLibraryPlacements,
                _ => null,
            };
        }
    }
}