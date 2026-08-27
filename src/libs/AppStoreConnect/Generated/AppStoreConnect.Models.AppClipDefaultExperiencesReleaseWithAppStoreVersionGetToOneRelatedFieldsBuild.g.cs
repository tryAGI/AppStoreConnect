
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild
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
    public static class AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild value)
        {
            return value switch
            {
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.App => "app",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BetaGroups => "betaGroups",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BuildBundles => "buildBundles",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BuildUpload => "buildUpload",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.ExpirationDate => "expirationDate",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.Expired => "expired",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.Icons => "icons",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.IndividualTesters => "individualTesters",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.ProcessingState => "processingState",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.UploadedDate => "uploadedDate",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BuildBundles,
                "buildUpload" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.ExpirationDate,
                "expired" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.Expired,
                "iconAssetToken" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.IconAssetToken,
                "icons" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.Icons,
                "individualTesters" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}