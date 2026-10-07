
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo
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
    public static class AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Category => "category",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate => "createdDate",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileName => "fileName",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize => "fileSize",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate => "lastModifiedDate",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Placements => "placements",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage => "previewFrameImage",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName => "referenceName",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId => "specId",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.State => "state",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails => "stateDetails",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations => "uploadOperations",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset => "videoAsset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Category,
                "createdDate" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate,
                "fileName" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileName,
                "fileSize" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize,
                "lastModifiedDate" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate,
                "placements" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Placements,
                "previewFrameImage" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage,
                "previewFrameTimeCode" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode,
                "referenceName" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName,
                "specId" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId,
                "state" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.State,
                "stateDetails" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails,
                "uploadOperations" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations,
                "videoAsset" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset,
                _ => null,
            };
        }
    }
}