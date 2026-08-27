
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild
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
    public static class AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild value)
        {
            return value switch
            {
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.App => "app",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BetaGroups => "betaGroups",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BuildBundles => "buildBundles",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BuildUpload => "buildUpload",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.ExpirationDate => "expirationDate",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.Expired => "expired",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.Icons => "icons",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.IndividualTesters => "individualTesters",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.ProcessingState => "processingState",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.UploadedDate => "uploadedDate",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BuildBundles,
                "buildUpload" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.ExpirationDate,
                "expired" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.Expired,
                "iconAssetToken" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.IconAssetToken,
                "icons" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.Icons,
                "individualTesters" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}