
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetInstanceFieldsBuild
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
    public static class AppsGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsBuild value)
        {
            return value switch
            {
                AppsGetInstanceFieldsBuild.App => "app",
                AppsGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                AppsGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                AppsGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                AppsGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                AppsGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                AppsGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                AppsGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                AppsGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                AppsGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                AppsGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                AppsGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                AppsGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                AppsGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                AppsGetInstanceFieldsBuild.Expired => "expired",
                AppsGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                AppsGetInstanceFieldsBuild.Icons => "icons",
                AppsGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                AppsGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                AppsGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                AppsGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                AppsGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                AppsGetInstanceFieldsBuild.ProcessingState => "processingState",
                AppsGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                AppsGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                AppsGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => AppsGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => AppsGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => AppsGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => AppsGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => AppsGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => AppsGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => AppsGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => AppsGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => AppsGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => AppsGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => AppsGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => AppsGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => AppsGetInstanceFieldsBuild.ExpirationDate,
                "expired" => AppsGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => AppsGetInstanceFieldsBuild.IconAssetToken,
                "icons" => AppsGetInstanceFieldsBuild.Icons,
                "individualTesters" => AppsGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => AppsGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => AppsGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => AppsGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => AppsGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => AppsGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => AppsGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => AppsGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => AppsGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}