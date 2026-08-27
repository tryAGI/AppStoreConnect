
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild
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
    public static class BetaFeedbackCrashSubmissionsGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild value)
        {
            return value switch
            {
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.App => "app",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.Expired => "expired",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.Icons => "icons",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.ProcessingState => "processingState",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.ExpirationDate,
                "expired" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.IconAssetToken,
                "icons" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.Icons,
                "individualTesters" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}