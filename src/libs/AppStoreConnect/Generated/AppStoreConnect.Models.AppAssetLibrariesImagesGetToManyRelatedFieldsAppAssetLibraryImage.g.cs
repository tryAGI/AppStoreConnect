
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage
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
    public static class AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage value)
        {
            return value switch
            {
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.Category => "category",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate => "createdDate",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.FileName => "fileName",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.FileSize => "fileSize",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset => "imageAsset",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate => "lastModifiedDate",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.Placements => "placements",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName => "referenceName",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.SpecId => "specId",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.State => "state",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails => "stateDetails",
                AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.Category,
                "createdDate" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate,
                "fileName" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.FileName,
                "fileSize" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.FileSize,
                "imageAsset" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset,
                "lastModifiedDate" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate,
                "placements" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.Placements,
                "referenceName" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName,
                "specId" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.SpecId,
                "state" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.State,
                "stateDetails" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails,
                "uploadOperations" => AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations,
                _ => null,
            };
        }
    }
}