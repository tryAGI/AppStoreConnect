
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage
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
    public static class AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage value)
        {
            return value switch
            {
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Category => "category",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate => "createdDate",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileName => "fileName",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileSize => "fileSize",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset => "imageAsset",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Placements => "placements",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName => "referenceName",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.SpecId => "specId",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.State => "state",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails => "stateDetails",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Category,
                "createdDate" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate,
                "fileName" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileName,
                "fileSize" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileSize,
                "imageAsset" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset,
                "lastModifiedDate" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate,
                "placements" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Placements,
                "referenceName" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName,
                "specId" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.SpecId,
                "state" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.State,
                "stateDetails" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails,
                "uploadOperations" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations,
                _ => null,
            };
        }
    }
}