
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadsGetInstanceFieldsBuildUploadFile
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
    public static class BuildUploadsGetInstanceFieldsBuildUploadFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadsGetInstanceFieldsBuildUploadFile value)
        {
            return value switch
            {
                BuildUploadsGetInstanceFieldsBuildUploadFile.AssetDeliveryState => "assetDeliveryState",
                BuildUploadsGetInstanceFieldsBuildUploadFile.AssetToken => "assetToken",
                BuildUploadsGetInstanceFieldsBuildUploadFile.AssetType => "assetType",
                BuildUploadsGetInstanceFieldsBuildUploadFile.FileName => "fileName",
                BuildUploadsGetInstanceFieldsBuildUploadFile.FileSize => "fileSize",
                BuildUploadsGetInstanceFieldsBuildUploadFile.SourceFileChecksums => "sourceFileChecksums",
                BuildUploadsGetInstanceFieldsBuildUploadFile.UploadOperations => "uploadOperations",
                BuildUploadsGetInstanceFieldsBuildUploadFile.Uti => "uti",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadsGetInstanceFieldsBuildUploadFile? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => BuildUploadsGetInstanceFieldsBuildUploadFile.AssetDeliveryState,
                "assetToken" => BuildUploadsGetInstanceFieldsBuildUploadFile.AssetToken,
                "assetType" => BuildUploadsGetInstanceFieldsBuildUploadFile.AssetType,
                "fileName" => BuildUploadsGetInstanceFieldsBuildUploadFile.FileName,
                "fileSize" => BuildUploadsGetInstanceFieldsBuildUploadFile.FileSize,
                "sourceFileChecksums" => BuildUploadsGetInstanceFieldsBuildUploadFile.SourceFileChecksums,
                "uploadOperations" => BuildUploadsGetInstanceFieldsBuildUploadFile.UploadOperations,
                "uti" => BuildUploadsGetInstanceFieldsBuildUploadFile.Uti,
                _ => null,
            };
        }
    }
}