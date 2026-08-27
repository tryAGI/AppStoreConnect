
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadFilesGetInstanceFieldsBuildUploadFile
    {
        /// <summary>
        ///
        /// </summary>
        AssetDeliveryState,
        /// <summary>
        ///
        /// </summary>
        AssetToken,
        /// <summary>
        ///
        /// </summary>
        AssetType,
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
        SourceFileChecksums,
        /// <summary>
        ///
        /// </summary>
        UploadOperations,
        /// <summary>
        ///
        /// </summary>
        Uti,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadFilesGetInstanceFieldsBuildUploadFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadFilesGetInstanceFieldsBuildUploadFile value)
        {
            return value switch
            {
                BuildUploadFilesGetInstanceFieldsBuildUploadFile.AssetDeliveryState => "assetDeliveryState",
                BuildUploadFilesGetInstanceFieldsBuildUploadFile.AssetToken => "assetToken",
                BuildUploadFilesGetInstanceFieldsBuildUploadFile.AssetType => "assetType",
                BuildUploadFilesGetInstanceFieldsBuildUploadFile.FileName => "fileName",
                BuildUploadFilesGetInstanceFieldsBuildUploadFile.FileSize => "fileSize",
                BuildUploadFilesGetInstanceFieldsBuildUploadFile.SourceFileChecksums => "sourceFileChecksums",
                BuildUploadFilesGetInstanceFieldsBuildUploadFile.UploadOperations => "uploadOperations",
                BuildUploadFilesGetInstanceFieldsBuildUploadFile.Uti => "uti",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadFilesGetInstanceFieldsBuildUploadFile? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => BuildUploadFilesGetInstanceFieldsBuildUploadFile.AssetDeliveryState,
                "assetToken" => BuildUploadFilesGetInstanceFieldsBuildUploadFile.AssetToken,
                "assetType" => BuildUploadFilesGetInstanceFieldsBuildUploadFile.AssetType,
                "fileName" => BuildUploadFilesGetInstanceFieldsBuildUploadFile.FileName,
                "fileSize" => BuildUploadFilesGetInstanceFieldsBuildUploadFile.FileSize,
                "sourceFileChecksums" => BuildUploadFilesGetInstanceFieldsBuildUploadFile.SourceFileChecksums,
                "uploadOperations" => BuildUploadFilesGetInstanceFieldsBuildUploadFile.UploadOperations,
                "uti" => BuildUploadFilesGetInstanceFieldsBuildUploadFile.Uti,
                _ => null,
            };
        }
    }
}