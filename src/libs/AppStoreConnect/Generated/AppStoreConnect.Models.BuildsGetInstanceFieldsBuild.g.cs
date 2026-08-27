
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetInstanceFieldsBuild
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
    public static class BuildsGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceFieldsBuild value)
        {
            return value switch
            {
                BuildsGetInstanceFieldsBuild.App => "app",
                BuildsGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BuildsGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                BuildsGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BuildsGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BuildsGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                BuildsGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                BuildsGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BuildsGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                BuildsGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                BuildsGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BuildsGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BuildsGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BuildsGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                BuildsGetInstanceFieldsBuild.Expired => "expired",
                BuildsGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                BuildsGetInstanceFieldsBuild.Icons => "icons",
                BuildsGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                BuildsGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BuildsGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                BuildsGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BuildsGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BuildsGetInstanceFieldsBuild.ProcessingState => "processingState",
                BuildsGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                BuildsGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BuildsGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => BuildsGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BuildsGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BuildsGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BuildsGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BuildsGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => BuildsGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BuildsGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => BuildsGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => BuildsGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BuildsGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BuildsGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BuildsGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BuildsGetInstanceFieldsBuild.ExpirationDate,
                "expired" => BuildsGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => BuildsGetInstanceFieldsBuild.IconAssetToken,
                "icons" => BuildsGetInstanceFieldsBuild.Icons,
                "individualTesters" => BuildsGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BuildsGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BuildsGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BuildsGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BuildsGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => BuildsGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => BuildsGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BuildsGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => BuildsGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}