
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage
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
    public static class RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage value)
        {
            return value switch
            {
                RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage.AppStoreVersion => "appStoreVersion",
                RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage.AssetDeliveryState => "assetDeliveryState",
                RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage.FileName => "fileName",
                RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage.FileSize => "fileSize",
                RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage.SourceFileChecksum => "sourceFileChecksum",
                RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage.AppStoreVersion,
                "assetDeliveryState" => RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage.AssetDeliveryState,
                "fileName" => RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage.FileName,
                "fileSize" => RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage.FileSize,
                "sourceFileChecksum" => RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage.SourceFileChecksum,
                "uploadOperations" => RoutingAppCoveragesGetInstanceFieldsRoutingAppCoverage.UploadOperations,
                _ => null,
            };
        }
    }
}