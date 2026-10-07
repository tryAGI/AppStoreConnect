
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryPlacements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemType.AppAssetLibraryPlacements => "appAssetLibraryPlacements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacements" => AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemType.AppAssetLibraryPlacements,
                _ => null,
            };
        }
    }
}