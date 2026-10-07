
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo
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
    public static class AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Category => "category",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate => "createdDate",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileName => "fileName",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize => "fileSize",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate => "lastModifiedDate",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Placements => "placements",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage => "previewFrameImage",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode => "previewFrameTimeCode",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName => "referenceName",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId => "specId",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.State => "state",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails => "stateDetails",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations => "uploadOperations",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset => "videoAsset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Category,
                "createdDate" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.CreatedDate,
                "fileName" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileName,
                "fileSize" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.FileSize,
                "lastModifiedDate" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.LastModifiedDate,
                "placements" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.Placements,
                "previewFrameImage" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameImage,
                "previewFrameTimeCode" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.PreviewFrameTimeCode,
                "referenceName" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.ReferenceName,
                "specId" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.SpecId,
                "state" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.State,
                "stateDetails" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.StateDetails,
                "uploadOperations" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.UploadOperations,
                "videoAsset" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryVideo.VideoAsset,
                _ => null,
            };
        }
    }
}