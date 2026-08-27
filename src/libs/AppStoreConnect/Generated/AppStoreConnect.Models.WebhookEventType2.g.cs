
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookEventType2
    {
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionPackageAvailableUpdated,
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionPackageVersionCreated,
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionTerritoryAvailabilityUpdated,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionAppVersionStateUpdated,
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetVersionAppStoreReleaseStateUpdated,
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetVersionExternalBetaReleaseStateUpdated,
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetVersionInternalBetaReleaseCreated,
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetVersionStateUpdated,
        /// <summary>
        /// 
        /// </summary>
        BetaFeedbackCrashSubmissionCreated,
        /// <summary>
        /// 
        /// </summary>
        BetaFeedbackScreenshotSubmissionCreated,
        /// <summary>
        /// 
        /// </summary>
        BuildBetaDetailExternalBuildStateUpdated,
        /// <summary>
        /// 
        /// </summary>
        BuildUploadStateUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEventType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEventType2 value)
        {
            return value switch
            {
                WebhookEventType2.AlternativeDistributionPackageAvailableUpdated => "ALTERNATIVE_DISTRIBUTION_PACKAGE_AVAILABLE_UPDATED",
                WebhookEventType2.AlternativeDistributionPackageVersionCreated => "ALTERNATIVE_DISTRIBUTION_PACKAGE_VERSION_CREATED",
                WebhookEventType2.AlternativeDistributionTerritoryAvailabilityUpdated => "ALTERNATIVE_DISTRIBUTION_TERRITORY_AVAILABILITY_UPDATED",
                WebhookEventType2.AppStoreVersionAppVersionStateUpdated => "APP_STORE_VERSION_APP_VERSION_STATE_UPDATED",
                WebhookEventType2.BackgroundAssetVersionAppStoreReleaseStateUpdated => "BACKGROUND_ASSET_VERSION_APP_STORE_RELEASE_STATE_UPDATED",
                WebhookEventType2.BackgroundAssetVersionExternalBetaReleaseStateUpdated => "BACKGROUND_ASSET_VERSION_EXTERNAL_BETA_RELEASE_STATE_UPDATED",
                WebhookEventType2.BackgroundAssetVersionInternalBetaReleaseCreated => "BACKGROUND_ASSET_VERSION_INTERNAL_BETA_RELEASE_CREATED",
                WebhookEventType2.BackgroundAssetVersionStateUpdated => "BACKGROUND_ASSET_VERSION_STATE_UPDATED",
                WebhookEventType2.BetaFeedbackCrashSubmissionCreated => "BETA_FEEDBACK_CRASH_SUBMISSION_CREATED",
                WebhookEventType2.BetaFeedbackScreenshotSubmissionCreated => "BETA_FEEDBACK_SCREENSHOT_SUBMISSION_CREATED",
                WebhookEventType2.BuildBetaDetailExternalBuildStateUpdated => "BUILD_BETA_DETAIL_EXTERNAL_BUILD_STATE_UPDATED",
                WebhookEventType2.BuildUploadStateUpdated => "BUILD_UPLOAD_STATE_UPDATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEventType2? ToEnum(string value)
        {
            return value switch
            {
                "ALTERNATIVE_DISTRIBUTION_PACKAGE_AVAILABLE_UPDATED" => WebhookEventType2.AlternativeDistributionPackageAvailableUpdated,
                "ALTERNATIVE_DISTRIBUTION_PACKAGE_VERSION_CREATED" => WebhookEventType2.AlternativeDistributionPackageVersionCreated,
                "ALTERNATIVE_DISTRIBUTION_TERRITORY_AVAILABILITY_UPDATED" => WebhookEventType2.AlternativeDistributionTerritoryAvailabilityUpdated,
                "APP_STORE_VERSION_APP_VERSION_STATE_UPDATED" => WebhookEventType2.AppStoreVersionAppVersionStateUpdated,
                "BACKGROUND_ASSET_VERSION_APP_STORE_RELEASE_STATE_UPDATED" => WebhookEventType2.BackgroundAssetVersionAppStoreReleaseStateUpdated,
                "BACKGROUND_ASSET_VERSION_EXTERNAL_BETA_RELEASE_STATE_UPDATED" => WebhookEventType2.BackgroundAssetVersionExternalBetaReleaseStateUpdated,
                "BACKGROUND_ASSET_VERSION_INTERNAL_BETA_RELEASE_CREATED" => WebhookEventType2.BackgroundAssetVersionInternalBetaReleaseCreated,
                "BACKGROUND_ASSET_VERSION_STATE_UPDATED" => WebhookEventType2.BackgroundAssetVersionStateUpdated,
                "BETA_FEEDBACK_CRASH_SUBMISSION_CREATED" => WebhookEventType2.BetaFeedbackCrashSubmissionCreated,
                "BETA_FEEDBACK_SCREENSHOT_SUBMISSION_CREATED" => WebhookEventType2.BetaFeedbackScreenshotSubmissionCreated,
                "BUILD_BETA_DETAIL_EXTERNAL_BUILD_STATE_UPDATED" => WebhookEventType2.BuildBetaDetailExternalBuildStateUpdated,
                "BUILD_UPLOAD_STATE_UPDATED" => WebhookEventType2.BuildUploadStateUpdated,
                _ => null,
            };
        }
    }
}