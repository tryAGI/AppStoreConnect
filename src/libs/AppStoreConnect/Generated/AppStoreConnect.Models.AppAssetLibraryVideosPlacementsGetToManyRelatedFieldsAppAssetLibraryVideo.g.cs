
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo
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
    public static class AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo value)
        {
            return value switch
            {
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Category => "category",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate => "createdDate",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileName => "fileName",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize => "fileSize",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Placements => "placements",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage => "previewFrameImage",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName => "referenceName",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId => "specId",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.State => "state",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails => "stateDetails",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations => "uploadOperations",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset => "videoAsset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Category,
                "createdDate" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate,
                "fileName" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileName,
                "fileSize" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize,
                "lastModifiedDate" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate,
                "placements" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Placements,
                "previewFrameImage" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage,
                "previewFrameTimeCode" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode,
                "referenceName" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName,
                "specId" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId,
                "state" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.State,
                "stateDetails" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails,
                "uploadOperations" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations,
                "videoAsset" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset,
                _ => null,
            };
        }
    }
}