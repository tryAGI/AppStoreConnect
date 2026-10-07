
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo
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
    public static class AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo value)
        {
            return value switch
            {
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Category => "category",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate => "createdDate",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileName => "fileName",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize => "fileSize",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate => "lastModifiedDate",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Placements => "placements",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage => "previewFrameImage",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName => "referenceName",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId => "specId",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.State => "state",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails => "stateDetails",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations => "uploadOperations",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset => "videoAsset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Category,
                "createdDate" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate,
                "fileName" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileName,
                "fileSize" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize,
                "lastModifiedDate" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate,
                "placements" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Placements,
                "previewFrameImage" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage,
                "previewFrameTimeCode" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode,
                "referenceName" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName,
                "specId" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId,
                "state" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.State,
                "stateDetails" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails,
                "uploadOperations" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations,
                "videoAsset" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset,
                _ => null,
            };
        }
    }
}