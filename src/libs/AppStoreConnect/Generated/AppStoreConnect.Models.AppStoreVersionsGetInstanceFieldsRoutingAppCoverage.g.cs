
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsGetInstanceFieldsRoutingAppCoverage
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
    public static class AppStoreVersionsGetInstanceFieldsRoutingAppCoverageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGetInstanceFieldsRoutingAppCoverage value)
        {
            return value switch
            {
                AppStoreVersionsGetInstanceFieldsRoutingAppCoverage.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsGetInstanceFieldsRoutingAppCoverage.AssetDeliveryState => "assetDeliveryState",
                AppStoreVersionsGetInstanceFieldsRoutingAppCoverage.FileName => "fileName",
                AppStoreVersionsGetInstanceFieldsRoutingAppCoverage.FileSize => "fileSize",
                AppStoreVersionsGetInstanceFieldsRoutingAppCoverage.SourceFileChecksum => "sourceFileChecksum",
                AppStoreVersionsGetInstanceFieldsRoutingAppCoverage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGetInstanceFieldsRoutingAppCoverage? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppStoreVersionsGetInstanceFieldsRoutingAppCoverage.AppStoreVersion,
                "assetDeliveryState" => AppStoreVersionsGetInstanceFieldsRoutingAppCoverage.AssetDeliveryState,
                "fileName" => AppStoreVersionsGetInstanceFieldsRoutingAppCoverage.FileName,
                "fileSize" => AppStoreVersionsGetInstanceFieldsRoutingAppCoverage.FileSize,
                "sourceFileChecksum" => AppStoreVersionsGetInstanceFieldsRoutingAppCoverage.SourceFileChecksum,
                "uploadOperations" => AppStoreVersionsGetInstanceFieldsRoutingAppCoverage.UploadOperations,
                _ => null,
            };
        }
    }
}