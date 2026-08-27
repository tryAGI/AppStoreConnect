
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile
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
    public static class BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile value)
        {
            return value switch
            {
                BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.AssetDeliveryState => "assetDeliveryState",
                BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.AssetToken => "assetToken",
                BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.AssetType => "assetType",
                BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.FileName => "fileName",
                BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.FileSize => "fileSize",
                BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.SourceFileChecksums => "sourceFileChecksums",
                BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.UploadOperations => "uploadOperations",
                BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.Uti => "uti",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.AssetDeliveryState,
                "assetToken" => BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.AssetToken,
                "assetType" => BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.AssetType,
                "fileName" => BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.FileName,
                "fileSize" => BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.FileSize,
                "sourceFileChecksums" => BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.SourceFileChecksums,
                "uploadOperations" => BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.UploadOperations,
                "uti" => BuildUploadsBuildUploadFilesGetToManyRelatedFieldsBuildUploadFile.Uti,
                _ => null,
            };
        }
    }
}