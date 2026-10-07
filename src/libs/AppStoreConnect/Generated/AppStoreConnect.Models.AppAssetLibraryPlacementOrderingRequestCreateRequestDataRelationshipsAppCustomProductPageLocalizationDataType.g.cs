
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType.AppCustomProductPageLocalizations,
                _ => null,
            };
        }
    }
}