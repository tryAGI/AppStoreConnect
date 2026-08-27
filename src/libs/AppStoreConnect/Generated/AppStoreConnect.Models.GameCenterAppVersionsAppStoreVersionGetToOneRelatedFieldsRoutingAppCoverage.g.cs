
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage
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
    public static class GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage value)
        {
            return value switch
            {
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.AppStoreVersion => "appStoreVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.AssetDeliveryState => "assetDeliveryState",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.FileName => "fileName",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.FileSize => "fileSize",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.SourceFileChecksum => "sourceFileChecksum",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.AppStoreVersion,
                "assetDeliveryState" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.AssetDeliveryState,
                "fileName" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.FileName,
                "fileSize" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.FileSize,
                "sourceFileChecksum" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.SourceFileChecksum,
                "uploadOperations" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.UploadOperations,
                _ => null,
            };
        }
    }
}