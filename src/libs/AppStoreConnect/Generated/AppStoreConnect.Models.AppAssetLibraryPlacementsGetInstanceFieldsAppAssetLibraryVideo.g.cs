
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo
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
    public static class AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo value)
        {
            return value switch
            {
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.Category => "category",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.CreatedDate => "createdDate",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.FileName => "fileName",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.FileSize => "fileSize",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.Placements => "placements",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.PreviewFrameImage => "previewFrameImage",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.ReferenceName => "referenceName",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.SpecId => "specId",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.State => "state",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.StateDetails => "stateDetails",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.UploadOperations => "uploadOperations",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.VideoAsset => "videoAsset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.Category,
                "createdDate" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.CreatedDate,
                "fileName" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.FileName,
                "fileSize" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.FileSize,
                "lastModifiedDate" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.LastModifiedDate,
                "placements" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.Placements,
                "previewFrameImage" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.PreviewFrameImage,
                "previewFrameTimeCode" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.PreviewFrameTimeCode,
                "referenceName" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.ReferenceName,
                "specId" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.SpecId,
                "state" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.State,
                "stateDetails" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.StateDetails,
                "uploadOperations" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.UploadOperations,
                "videoAsset" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryVideo.VideoAsset,
                _ => null,
            };
        }
    }
}