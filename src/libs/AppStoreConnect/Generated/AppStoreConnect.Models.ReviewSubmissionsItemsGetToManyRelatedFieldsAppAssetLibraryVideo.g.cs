
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo
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
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.Category => "category",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate => "createdDate",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.FileName => "fileName",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize => "fileSize",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate => "lastModifiedDate",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.Placements => "placements",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage => "previewFrameImage",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode => "previewFrameTimeCode",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName => "referenceName",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId => "specId",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails => "stateDetails",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations => "uploadOperations",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset => "videoAsset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo? ToEnum(string value)
        {
            return value switch
            {
                "category" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.Category,
                "createdDate" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate,
                "fileName" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.FileName,
                "fileSize" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize,
                "lastModifiedDate" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate,
                "placements" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.Placements,
                "previewFrameImage" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage,
                "previewFrameTimeCode" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode,
                "referenceName" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName,
                "specId" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.State,
                "stateDetails" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails,
                "uploadOperations" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations,
                "videoAsset" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset,
                _ => null,
            };
        }
    }
}