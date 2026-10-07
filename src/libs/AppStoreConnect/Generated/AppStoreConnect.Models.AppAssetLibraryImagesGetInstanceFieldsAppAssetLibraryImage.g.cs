
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage
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
    public static class AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage value)
        {
            return value switch
            {
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.Category => "category",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.CreatedDate => "createdDate",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.FileName => "fileName",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.FileSize => "fileSize",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.ImageAsset => "imageAsset",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.Placements => "placements",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.ReferenceName => "referenceName",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.SpecId => "specId",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.State => "state",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.StateDetails => "stateDetails",
                AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.Category,
                "createdDate" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.CreatedDate,
                "fileName" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.FileName,
                "fileSize" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.FileSize,
                "imageAsset" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.ImageAsset,
                "lastModifiedDate" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.LastModifiedDate,
                "placements" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.Placements,
                "referenceName" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.ReferenceName,
                "specId" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.SpecId,
                "state" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.State,
                "stateDetails" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.StateDetails,
                "uploadOperations" => AppAssetLibraryImagesGetInstanceFieldsAppAssetLibraryImage.UploadOperations,
                _ => null,
            };
        }
    }
}