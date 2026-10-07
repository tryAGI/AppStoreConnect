
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionLocalizations" => AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}