
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo
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
        LastModifiedDate,
        /// <summary>
        ///
        /// </summary>
        Placements,
        /// <summary>
        ///
        /// </summary>
        PreviewFrameImage,
        /// <summary>
        ///
        /// </summary>
        PreviewFrameTimeCode,
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
        /// <summary>
        ///
        /// </summary>
        VideoAsset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo value)
        {
            return value switch
            {
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Category => "category",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate => "createdDate",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileName => "fileName",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize => "fileSize",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Placements => "placements",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage => "previewFrameImage",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName => "referenceName",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId => "specId",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.State => "state",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails => "stateDetails",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations => "uploadOperations",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset => "videoAsset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Category,
                "createdDate" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate,
                "fileName" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileName,
                "fileSize" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize,
                "lastModifiedDate" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate,
                "placements" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Placements,
                "previewFrameImage" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage,
                "previewFrameTimeCode" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode,
                "referenceName" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName,
                "specId" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId,
                "state" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.State,
                "stateDetails" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails,
                "uploadOperations" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations,
                "videoAsset" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset,
                _ => null,
            };
        }
    }
}