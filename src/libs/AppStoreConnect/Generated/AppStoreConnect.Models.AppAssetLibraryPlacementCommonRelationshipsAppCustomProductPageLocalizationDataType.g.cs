
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType.AppCustomProductPageLocalizations,
                _ => null,
            };
        }
    }
}