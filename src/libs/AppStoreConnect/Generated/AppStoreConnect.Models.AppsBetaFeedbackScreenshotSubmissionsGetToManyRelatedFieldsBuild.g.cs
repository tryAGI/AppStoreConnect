
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        AppEncryptionDeclaration,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersion,
        /// <summary>
        /// 
        /// </summary>
        BetaAppReviewSubmission,
        /// <summary>
        /// 
        /// </summary>
        BetaBuildLocalizations,
        /// <summary>
        /// 
        /// </summary>
        BetaGroups,
        /// <summary>
        /// 
        /// </summary>
        BuildAudienceType,
        /// <summary>
        /// 
        /// </summary>
        BuildBetaDetail,
        /// <summary>
        /// 
        /// </summary>
        BuildBundles,
        /// <summary>
        /// 
        /// </summary>
        BuildUpload,
        /// <summary>
        /// 
        /// </summary>
        ComputedMinMacOsVersion,
        /// <summary>
        /// 
        /// </summary>
        ComputedMinVisionOsVersion,
        /// <summary>
        /// 
        /// </summary>
        DiagnosticSignatures,
        /// <summary>
        /// 
        /// </summary>
        ExpirationDate,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        IconAssetToken,
        /// <summary>
        /// 
        /// </summary>
        Icons,
        /// <summary>
        /// 
        /// </summary>
        IndividualTesters,
        /// <summary>
        /// 
        /// </summary>
        LsMinimumSystemVersion,
        /// <summary>
        /// 
        /// </summary>
        MinOsVersion,
        /// <summary>
        /// 
        /// </summary>
        PerfPowerMetrics,
        /// <summary>
        /// 
        /// </summary>
        PreReleaseVersion,
        /// <summary>
        /// 
        /// </summary>
        ProcessingState,
        /// <summary>
        /// 
        /// </summary>
        UploadedDate,
        /// <summary>
        /// 
        /// </summary>
        UsesNonExemptEncryption,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild value)
        {
            return value switch
            {
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.App => "app",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BetaGroups => "betaGroups",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BuildBundles => "buildBundles",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BuildUpload => "buildUpload",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.ExpirationDate => "expirationDate",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.Expired => "expired",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.Icons => "icons",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.IndividualTesters => "individualTesters",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.ProcessingState => "processingState",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.UploadedDate => "uploadedDate",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BuildBundles,
                "buildUpload" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.ExpirationDate,
                "expired" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.Expired,
                "iconAssetToken" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.IconAssetToken,
                "icons" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.Icons,
                "individualTesters" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}