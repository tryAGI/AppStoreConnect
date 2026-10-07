
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo
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
    public static class AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo value)
        {
            return value switch
            {
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.Category => "category",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.CreatedDate => "createdDate",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.FileName => "fileName",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.FileSize => "fileSize",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.Placements => "placements",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.PreviewFrameImage => "previewFrameImage",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.ReferenceName => "referenceName",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.SpecId => "specId",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.State => "state",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.StateDetails => "stateDetails",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.UploadOperations => "uploadOperations",
                AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.VideoAsset => "videoAsset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.Category,
                "createdDate" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.CreatedDate,
                "fileName" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.FileName,
                "fileSize" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.FileSize,
                "lastModifiedDate" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.LastModifiedDate,
                "placements" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.Placements,
                "previewFrameImage" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.PreviewFrameImage,
                "previewFrameTimeCode" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.PreviewFrameTimeCode,
                "referenceName" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.ReferenceName,
                "specId" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.SpecId,
                "state" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.State,
                "stateDetails" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.StateDetails,
                "uploadOperations" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.UploadOperations,
                "videoAsset" => AppAssetLibraryVideosGetInstanceFieldsAppAssetLibraryVideo.VideoAsset,
                _ => null,
            };
        }
    }
}