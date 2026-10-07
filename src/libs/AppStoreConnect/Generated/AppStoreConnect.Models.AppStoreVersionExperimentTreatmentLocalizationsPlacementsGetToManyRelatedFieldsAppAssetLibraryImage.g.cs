
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage
    {
        /// <summary>
        ///
        /// </summary>
        Category,
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
        /// <summary>
        ///
        /// </summary>
        FileName,
        /// <summary>
        ///
        /// </summary>
        FileSize,
        /// <summary>
        ///
        /// </summary>
        ImageAsset,
        /// <summary>
        ///
        /// </summary>
        LastModifiedDate,
        /// <summary>
        ///
        /// </summary>
        Placements,
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
        /// <summary>
        ///
        /// </summary>
        SpecId,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        StateDetails,
        /// <summary>
        ///
        /// </summary>
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Category => "category",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate => "createdDate",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileName => "fileName",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileSize => "fileSize",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset => "imageAsset",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate => "lastModifiedDate",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Placements => "placements",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName => "referenceName",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.SpecId => "specId",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.State => "state",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails => "stateDetails",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Category,
                "createdDate" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate,
                "fileName" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileName,
                "fileSize" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileSize,
                "imageAsset" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset,
                "lastModifiedDate" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate,
                "placements" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Placements,
                "referenceName" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName,
                "specId" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.SpecId,
                "state" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.State,
                "stateDetails" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails,
                "uploadOperations" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations,
                _ => null,
            };
        }
    }
}