
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage
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
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.Category => "category",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate => "createdDate",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.FileName => "fileName",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.FileSize => "fileSize",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset => "imageAsset",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate => "lastModifiedDate",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.Placements => "placements",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName => "referenceName",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.SpecId => "specId",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails => "stateDetails",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage? ToEnum(string value)
        {
            return value switch
            {
                "category" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.Category,
                "createdDate" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.CreatedDate,
                "fileName" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.FileName,
                "fileSize" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.FileSize,
                "imageAsset" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.ImageAsset,
                "lastModifiedDate" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.LastModifiedDate,
                "placements" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.Placements,
                "referenceName" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.ReferenceName,
                "specId" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.SpecId,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.State,
                "stateDetails" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.StateDetails,
                "uploadOperations" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppAssetLibraryImage.UploadOperations,
                _ => null,
            };
        }
    }
}