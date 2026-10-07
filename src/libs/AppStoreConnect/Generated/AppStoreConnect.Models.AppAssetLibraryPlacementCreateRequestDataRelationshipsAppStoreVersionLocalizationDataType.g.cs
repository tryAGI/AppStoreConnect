
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionLocalizations" => AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}