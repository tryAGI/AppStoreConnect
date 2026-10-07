
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatmentLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatmentLocalizations" => AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType.AppStoreVersionExperimentTreatmentLocalizations,
                _ => null,
            };
        }
    }
}