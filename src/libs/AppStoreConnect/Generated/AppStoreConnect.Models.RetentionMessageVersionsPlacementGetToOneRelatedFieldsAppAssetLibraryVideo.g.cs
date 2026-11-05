
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo
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
    public static class RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo value)
        {
            return value switch
            {
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.Category => "category",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.CreatedDate => "createdDate",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.FileName => "fileName",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.FileSize => "fileSize",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.LastModifiedDate => "lastModifiedDate",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.Placements => "placements",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage => "previewFrameImage",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode => "previewFrameTimeCode",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.ReferenceName => "referenceName",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.SpecId => "specId",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.State => "state",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.StateDetails => "stateDetails",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.UploadOperations => "uploadOperations",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.VideoAsset => "videoAsset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo? ToEnum(string value)
        {
            return value switch
            {
                "category" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.Category,
                "createdDate" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.CreatedDate,
                "fileName" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.FileName,
                "fileSize" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.FileSize,
                "lastModifiedDate" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.LastModifiedDate,
                "placements" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.Placements,
                "previewFrameImage" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage,
                "previewFrameTimeCode" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode,
                "referenceName" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.ReferenceName,
                "specId" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.SpecId,
                "state" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.State,
                "stateDetails" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.StateDetails,
                "uploadOperations" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.UploadOperations,
                "videoAsset" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryVideo.VideoAsset,
                _ => null,
            };
        }
    }
}