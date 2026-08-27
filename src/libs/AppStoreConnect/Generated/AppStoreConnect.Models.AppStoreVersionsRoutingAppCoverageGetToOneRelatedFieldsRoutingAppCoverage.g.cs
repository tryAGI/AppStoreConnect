
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersion,
        /// <summary>
        ///
        /// </summary>
        AssetDeliveryState,
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
        SourceFileChecksum,
        /// <summary>
        ///
        /// </summary>
        UploadOperations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage value)
        {
            return value switch
            {
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage.AssetDeliveryState => "assetDeliveryState",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage.FileName => "fileName",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage.FileSize => "fileSize",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage.SourceFileChecksum => "sourceFileChecksum",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage.AppStoreVersion,
                "assetDeliveryState" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage.AssetDeliveryState,
                "fileName" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage.FileName,
                "fileSize" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage.FileSize,
                "sourceFileChecksum" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage.SourceFileChecksum,
                "uploadOperations" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage.UploadOperations,
                _ => null,
            };
        }
    }
}