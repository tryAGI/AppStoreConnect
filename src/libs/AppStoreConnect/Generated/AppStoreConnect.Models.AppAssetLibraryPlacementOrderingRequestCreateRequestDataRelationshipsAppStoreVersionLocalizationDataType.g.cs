
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionLocalizations" => AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}