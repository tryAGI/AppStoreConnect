
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookEventType
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
    public static class WebhookEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEventType value)
        {
            return value switch
            {
                WebhookEventType.AlternativeDistributionPackageAvailableUpdated => "ALTERNATIVE_DISTRIBUTION_PACKAGE_AVAILABLE_UPDATED",
                WebhookEventType.AlternativeDistributionPackageVersionCreated => "ALTERNATIVE_DISTRIBUTION_PACKAGE_VERSION_CREATED",
                WebhookEventType.AlternativeDistributionTerritoryAvailabilityUpdated => "ALTERNATIVE_DISTRIBUTION_TERRITORY_AVAILABILITY_UPDATED",
                WebhookEventType.AppStoreVersionAppVersionStateUpdated => "APP_STORE_VERSION_APP_VERSION_STATE_UPDATED",
                WebhookEventType.BackgroundAssetVersionAppStoreReleaseStateUpdated => "BACKGROUND_ASSET_VERSION_APP_STORE_RELEASE_STATE_UPDATED",
                WebhookEventType.BackgroundAssetVersionExternalBetaReleaseStateUpdated => "BACKGROUND_ASSET_VERSION_EXTERNAL_BETA_RELEASE_STATE_UPDATED",
                WebhookEventType.BackgroundAssetVersionInternalBetaReleaseCreated => "BACKGROUND_ASSET_VERSION_INTERNAL_BETA_RELEASE_CREATED",
                WebhookEventType.BackgroundAssetVersionStateUpdated => "BACKGROUND_ASSET_VERSION_STATE_UPDATED",
                WebhookEventType.BetaFeedbackCrashSubmissionCreated => "BETA_FEEDBACK_CRASH_SUBMISSION_CREATED",
                WebhookEventType.BetaFeedbackScreenshotSubmissionCreated => "BETA_FEEDBACK_SCREENSHOT_SUBMISSION_CREATED",
                WebhookEventType.BuildBetaDetailExternalBuildStateUpdated => "BUILD_BETA_DETAIL_EXTERNAL_BUILD_STATE_UPDATED",
                WebhookEventType.BuildUploadStateUpdated => "BUILD_UPLOAD_STATE_UPDATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEventType? ToEnum(string value)
        {
            return value switch
            {
                "ALTERNATIVE_DISTRIBUTION_PACKAGE_AVAILABLE_UPDATED" => WebhookEventType.AlternativeDistributionPackageAvailableUpdated,
                "ALTERNATIVE_DISTRIBUTION_PACKAGE_VERSION_CREATED" => WebhookEventType.AlternativeDistributionPackageVersionCreated,
                "ALTERNATIVE_DISTRIBUTION_TERRITORY_AVAILABILITY_UPDATED" => WebhookEventType.AlternativeDistributionTerritoryAvailabilityUpdated,
                "APP_STORE_VERSION_APP_VERSION_STATE_UPDATED" => WebhookEventType.AppStoreVersionAppVersionStateUpdated,
                "BACKGROUND_ASSET_VERSION_APP_STORE_RELEASE_STATE_UPDATED" => WebhookEventType.BackgroundAssetVersionAppStoreReleaseStateUpdated,
                "BACKGROUND_ASSET_VERSION_EXTERNAL_BETA_RELEASE_STATE_UPDATED" => WebhookEventType.BackgroundAssetVersionExternalBetaReleaseStateUpdated,
                "BACKGROUND_ASSET_VERSION_INTERNAL_BETA_RELEASE_CREATED" => WebhookEventType.BackgroundAssetVersionInternalBetaReleaseCreated,
                "BACKGROUND_ASSET_VERSION_STATE_UPDATED" => WebhookEventType.BackgroundAssetVersionStateUpdated,
                "BETA_FEEDBACK_CRASH_SUBMISSION_CREATED" => WebhookEventType.BetaFeedbackCrashSubmissionCreated,
                "BETA_FEEDBACK_SCREENSHOT_SUBMISSION_CREATED" => WebhookEventType.BetaFeedbackScreenshotSubmissionCreated,
                "BUILD_BETA_DETAIL_EXTERNAL_BUILD_STATE_UPDATED" => WebhookEventType.BuildBetaDetailExternalBuildStateUpdated,
                "BUILD_UPLOAD_STATE_UPDATED" => WebhookEventType.BuildUploadStateUpdated,
                _ => null,
            };
        }
    }
}