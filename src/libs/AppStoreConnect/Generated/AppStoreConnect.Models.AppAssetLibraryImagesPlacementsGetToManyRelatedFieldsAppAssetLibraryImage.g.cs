
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage
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
    public static class AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage value)
        {
            return value switch
            {
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Category => "category",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate => "createdDate",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileName => "fileName",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileSize => "fileSize",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset => "imageAsset",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Placements => "placements",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName => "referenceName",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.SpecId => "specId",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.State => "state",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails => "stateDetails",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Category,
                "createdDate" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate,
                "fileName" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileName,
                "fileSize" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileSize,
                "imageAsset" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset,
                "lastModifiedDate" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate,
                "placements" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Placements,
                "referenceName" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName,
                "specId" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.SpecId,
                "state" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.State,
                "stateDetails" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails,
                "uploadOperations" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations,
                _ => null,
            };
        }
    }
}