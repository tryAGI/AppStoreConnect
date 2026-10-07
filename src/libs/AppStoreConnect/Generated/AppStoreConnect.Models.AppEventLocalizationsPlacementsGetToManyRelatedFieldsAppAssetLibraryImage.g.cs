
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage
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
    public static class AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage value)
        {
            return value switch
            {
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Category => "category",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate => "createdDate",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileName => "fileName",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileSize => "fileSize",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset => "imageAsset",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate => "lastModifiedDate",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Placements => "placements",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName => "referenceName",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.SpecId => "specId",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.State => "state",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails => "stateDetails",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Category,
                "createdDate" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate,
                "fileName" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileName,
                "fileSize" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileSize,
                "imageAsset" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset,
                "lastModifiedDate" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate,
                "placements" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Placements,
                "referenceName" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName,
                "specId" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.SpecId,
                "state" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.State,
                "stateDetails" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails,
                "uploadOperations" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations,
                _ => null,
            };
        }
    }
}