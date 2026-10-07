
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage
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
        ImageAsset,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Category => "category",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate => "createdDate",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileName => "fileName",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileSize => "fileSize",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset => "imageAsset",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate => "lastModifiedDate",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Placements => "placements",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName => "referenceName",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.SpecId => "specId",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.State => "state",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails => "stateDetails",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Category,
                "createdDate" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate,
                "fileName" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileName,
                "fileSize" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.FileSize,
                "imageAsset" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset,
                "lastModifiedDate" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate,
                "placements" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.Placements,
                "referenceName" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName,
                "specId" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.SpecId,
                "state" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.State,
                "stateDetails" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails,
                "uploadOperations" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations,
                _ => null,
            };
        }
    }
}