
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile
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
    public static class AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile value)
        {
            return value switch
            {
                AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.AssetDeliveryState => "assetDeliveryState",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.AssetToken => "assetToken",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.AssetType => "assetType",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.FileName => "fileName",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.FileSize => "fileSize",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.SourceFileChecksums => "sourceFileChecksums",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.UploadOperations => "uploadOperations",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.Uti => "uti",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile? ToEnum(string value)
        {
            return value switch
            {
                "assetDeliveryState" => AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.AssetDeliveryState,
                "assetToken" => AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.AssetToken,
                "assetType" => AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.AssetType,
                "fileName" => AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.FileName,
                "fileSize" => AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.FileSize,
                "sourceFileChecksums" => AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.SourceFileChecksums,
                "uploadOperations" => AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.UploadOperations,
                "uti" => AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile.Uti,
                _ => null,
            };
        }
    }
}