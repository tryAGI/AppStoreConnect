
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppAssetLibraryPlacementCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType.AppCustomProductPageLocalizations,
                _ => null,
            };
        }
    }
}