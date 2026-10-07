
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementCreateRequestDataRelationshipsAppEventLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementCreateRequestDataRelationshipsAppEventLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementCreateRequestDataRelationshipsAppEventLocalizationDataType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementCreateRequestDataRelationshipsAppEventLocalizationDataType.AppEventLocalizations => "appEventLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementCreateRequestDataRelationshipsAppEventLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEventLocalizations" => AppAssetLibraryPlacementCreateRequestDataRelationshipsAppEventLocalizationDataType.AppEventLocalizations,
                _ => null,
            };
        }
    }
}