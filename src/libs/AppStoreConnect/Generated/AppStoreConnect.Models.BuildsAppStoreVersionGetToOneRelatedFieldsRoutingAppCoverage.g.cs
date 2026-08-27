
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage
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
    public static class BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage value)
        {
            return value switch
            {
                BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.AppStoreVersion => "appStoreVersion",
                BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.AssetDeliveryState => "assetDeliveryState",
                BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.FileName => "fileName",
                BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.FileSize => "fileSize",
                BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.SourceFileChecksum => "sourceFileChecksum",
                BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.AppStoreVersion,
                "assetDeliveryState" => BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.AssetDeliveryState,
                "fileName" => BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.FileName,
                "fileSize" => BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.FileSize,
                "sourceFileChecksum" => BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.SourceFileChecksum,
                "uploadOperations" => BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.UploadOperations,
                _ => null,
            };
        }
    }
}