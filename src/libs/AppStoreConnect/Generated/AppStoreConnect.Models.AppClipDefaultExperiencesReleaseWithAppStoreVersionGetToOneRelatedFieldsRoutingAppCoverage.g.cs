
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage
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
    public static class AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage value)
        {
            return value switch
            {
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.AppStoreVersion => "appStoreVersion",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.AssetDeliveryState => "assetDeliveryState",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.FileName => "fileName",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.FileSize => "fileSize",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.SourceFileChecksum => "sourceFileChecksum",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.UploadOperations => "uploadOperations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.AppStoreVersion,
                "assetDeliveryState" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.AssetDeliveryState,
                "fileName" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.FileName,
                "fileSize" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.FileSize,
                "sourceFileChecksum" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.SourceFileChecksum,
                "uploadOperations" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage.UploadOperations,
                _ => null,
            };
        }
    }
}