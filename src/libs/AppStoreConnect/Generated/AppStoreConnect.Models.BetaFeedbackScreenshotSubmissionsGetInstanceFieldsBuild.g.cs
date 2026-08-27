
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild
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
    public static class BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild value)
        {
            return value switch
            {
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.App => "app",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.Expired => "expired",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.Icons => "icons",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.ProcessingState => "processingState",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.ExpirationDate,
                "expired" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.IconAssetToken,
                "icons" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.Icons,
                "individualTesters" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}