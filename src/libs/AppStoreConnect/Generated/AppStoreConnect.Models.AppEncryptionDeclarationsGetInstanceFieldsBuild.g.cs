
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationsGetInstanceFieldsBuild
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
    public static class AppEncryptionDeclarationsGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationsGetInstanceFieldsBuild value)
        {
            return value switch
            {
                AppEncryptionDeclarationsGetInstanceFieldsBuild.App => "app",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.Expired => "expired",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.Icons => "icons",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.ProcessingState => "processingState",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                AppEncryptionDeclarationsGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationsGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppEncryptionDeclarationsGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => AppEncryptionDeclarationsGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => AppEncryptionDeclarationsGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => AppEncryptionDeclarationsGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => AppEncryptionDeclarationsGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => AppEncryptionDeclarationsGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => AppEncryptionDeclarationsGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => AppEncryptionDeclarationsGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => AppEncryptionDeclarationsGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => AppEncryptionDeclarationsGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => AppEncryptionDeclarationsGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => AppEncryptionDeclarationsGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => AppEncryptionDeclarationsGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => AppEncryptionDeclarationsGetInstanceFieldsBuild.ExpirationDate,
                "expired" => AppEncryptionDeclarationsGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => AppEncryptionDeclarationsGetInstanceFieldsBuild.IconAssetToken,
                "icons" => AppEncryptionDeclarationsGetInstanceFieldsBuild.Icons,
                "individualTesters" => AppEncryptionDeclarationsGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => AppEncryptionDeclarationsGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => AppEncryptionDeclarationsGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => AppEncryptionDeclarationsGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => AppEncryptionDeclarationsGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => AppEncryptionDeclarationsGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => AppEncryptionDeclarationsGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => AppEncryptionDeclarationsGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => AppEncryptionDeclarationsGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}