
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage
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
    public static class AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage value)
        {
            return value switch
            {
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.Category => "category",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.CreatedDate => "createdDate",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.FileName => "fileName",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.FileSize => "fileSize",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.ImageAsset => "imageAsset",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.Placements => "placements",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.ReferenceName => "referenceName",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.SpecId => "specId",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.State => "state",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.StateDetails => "stateDetails",
                AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage? ToEnum(string value)
        {
            return value switch
            {
                "category" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.Category,
                "createdDate" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.CreatedDate,
                "fileName" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.FileName,
                "fileSize" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.FileSize,
                "imageAsset" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.ImageAsset,
                "lastModifiedDate" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.LastModifiedDate,
                "placements" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.Placements,
                "referenceName" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.ReferenceName,
                "specId" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.SpecId,
                "state" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.State,
                "stateDetails" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.StateDetails,
                "uploadOperations" => AppAssetLibraryPlacementsGetInstanceFieldsAppAssetLibraryImage.UploadOperations,
                _ => null,
            };
        }
    }
}