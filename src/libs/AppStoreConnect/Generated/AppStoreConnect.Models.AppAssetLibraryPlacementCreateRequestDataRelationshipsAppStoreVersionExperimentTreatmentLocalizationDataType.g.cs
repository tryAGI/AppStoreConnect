
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatmentLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatmentLocalizations" => AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType.AppStoreVersionExperimentTreatmentLocalizations,
                _ => null,
            };
        }
    }
}