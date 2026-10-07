
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo
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
    public static class AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo value)
        {
            return value switch
            {
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.Category => "category",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate => "createdDate",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.FileName => "fileName",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize => "fileSize",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate => "lastModifiedDate",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.Placements => "placements",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage => "previewFrameImage",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName => "referenceName",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId => "specId",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.State => "state",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails => "stateDetails",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations => "uploadOperations",
                AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset => "videoAsset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.Category,
                "createdDate" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate,
                "fileName" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.FileName,
                "fileSize" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize,
                "lastModifiedDate" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate,
                "placements" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.Placements,
                "previewFrameImage" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage,
                "previewFrameTimeCode" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode,
                "referenceName" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName,
                "specId" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId,
                "state" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.State,
                "stateDetails" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails,
                "uploadOperations" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations,
                "videoAsset" => AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset,
                _ => null,
            };
        }
    }
}