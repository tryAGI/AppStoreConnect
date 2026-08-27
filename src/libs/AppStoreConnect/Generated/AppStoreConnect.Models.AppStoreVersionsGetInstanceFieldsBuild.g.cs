
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsGetInstanceFieldsBuild
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
    public static class AppStoreVersionsGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGetInstanceFieldsBuild value)
        {
            return value switch
            {
                AppStoreVersionsGetInstanceFieldsBuild.App => "app",
                AppStoreVersionsGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                AppStoreVersionsGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                AppStoreVersionsGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                AppStoreVersionsGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                AppStoreVersionsGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                AppStoreVersionsGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                AppStoreVersionsGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                AppStoreVersionsGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                AppStoreVersionsGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                AppStoreVersionsGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                AppStoreVersionsGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                AppStoreVersionsGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                AppStoreVersionsGetInstanceFieldsBuild.Expired => "expired",
                AppStoreVersionsGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                AppStoreVersionsGetInstanceFieldsBuild.Icons => "icons",
                AppStoreVersionsGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                AppStoreVersionsGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                AppStoreVersionsGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                AppStoreVersionsGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                AppStoreVersionsGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                AppStoreVersionsGetInstanceFieldsBuild.ProcessingState => "processingState",
                AppStoreVersionsGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                AppStoreVersionsGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                AppStoreVersionsGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppStoreVersionsGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => AppStoreVersionsGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => AppStoreVersionsGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => AppStoreVersionsGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => AppStoreVersionsGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => AppStoreVersionsGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => AppStoreVersionsGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => AppStoreVersionsGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => AppStoreVersionsGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => AppStoreVersionsGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => AppStoreVersionsGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => AppStoreVersionsGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => AppStoreVersionsGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => AppStoreVersionsGetInstanceFieldsBuild.ExpirationDate,
                "expired" => AppStoreVersionsGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => AppStoreVersionsGetInstanceFieldsBuild.IconAssetToken,
                "icons" => AppStoreVersionsGetInstanceFieldsBuild.Icons,
                "individualTesters" => AppStoreVersionsGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => AppStoreVersionsGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => AppStoreVersionsGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => AppStoreVersionsGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => AppStoreVersionsGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => AppStoreVersionsGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => AppStoreVersionsGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => AppStoreVersionsGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => AppStoreVersionsGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}