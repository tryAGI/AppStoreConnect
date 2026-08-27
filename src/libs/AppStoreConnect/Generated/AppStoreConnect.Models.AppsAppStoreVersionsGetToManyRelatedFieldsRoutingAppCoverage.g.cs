
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage
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
    public static class AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage.AppStoreVersion => "appStoreVersion",
                AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage.AssetDeliveryState => "assetDeliveryState",
                AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage.FileName => "fileName",
                AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage.FileSize => "fileSize",
                AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage.SourceFileChecksum => "sourceFileChecksum",
                AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage.AppStoreVersion,
                "assetDeliveryState" => AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage.AssetDeliveryState,
                "fileName" => AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage.FileName,
                "fileSize" => AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage.FileSize,
                "sourceFileChecksum" => AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage.SourceFileChecksum,
                "uploadOperations" => AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage.UploadOperations,
                _ => null,
            };
        }
    }
}