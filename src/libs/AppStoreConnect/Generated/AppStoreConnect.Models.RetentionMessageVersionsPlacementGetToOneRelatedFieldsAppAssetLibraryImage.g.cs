
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage
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
    public static class RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage value)
        {
            return value switch
            {
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.Category => "category",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.CreatedDate => "createdDate",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.FileName => "fileName",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.FileSize => "fileSize",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.ImageAsset => "imageAsset",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.LastModifiedDate => "lastModifiedDate",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.Placements => "placements",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.ReferenceName => "referenceName",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.SpecId => "specId",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.State => "state",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.StateDetails => "stateDetails",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage? ToEnum(string value)
        {
            return value switch
            {
                "category" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.Category,
                "createdDate" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.CreatedDate,
                "fileName" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.FileName,
                "fileSize" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.FileSize,
                "imageAsset" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.ImageAsset,
                "lastModifiedDate" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.LastModifiedDate,
                "placements" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.Placements,
                "referenceName" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.ReferenceName,
                "specId" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.SpecId,
                "state" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.State,
                "stateDetails" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.StateDetails,
                "uploadOperations" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryImage.UploadOperations,
                _ => null,
            };
        }
    }
}