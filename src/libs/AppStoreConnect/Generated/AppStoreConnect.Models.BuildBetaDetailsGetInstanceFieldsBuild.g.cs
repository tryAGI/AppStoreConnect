
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaDetailsGetInstanceFieldsBuild
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
    public static class BuildBetaDetailsGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsGetInstanceFieldsBuild value)
        {
            return value switch
            {
                BuildBetaDetailsGetInstanceFieldsBuild.App => "app",
                BuildBetaDetailsGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BuildBetaDetailsGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                BuildBetaDetailsGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BuildBetaDetailsGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BuildBetaDetailsGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                BuildBetaDetailsGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                BuildBetaDetailsGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BuildBetaDetailsGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                BuildBetaDetailsGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                BuildBetaDetailsGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BuildBetaDetailsGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BuildBetaDetailsGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BuildBetaDetailsGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                BuildBetaDetailsGetInstanceFieldsBuild.Expired => "expired",
                BuildBetaDetailsGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                BuildBetaDetailsGetInstanceFieldsBuild.Icons => "icons",
                BuildBetaDetailsGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                BuildBetaDetailsGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BuildBetaDetailsGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                BuildBetaDetailsGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BuildBetaDetailsGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BuildBetaDetailsGetInstanceFieldsBuild.ProcessingState => "processingState",
                BuildBetaDetailsGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                BuildBetaDetailsGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BuildBetaDetailsGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildBetaDetailsGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => BuildBetaDetailsGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BuildBetaDetailsGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BuildBetaDetailsGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BuildBetaDetailsGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BuildBetaDetailsGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => BuildBetaDetailsGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BuildBetaDetailsGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => BuildBetaDetailsGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => BuildBetaDetailsGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BuildBetaDetailsGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BuildBetaDetailsGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BuildBetaDetailsGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BuildBetaDetailsGetInstanceFieldsBuild.ExpirationDate,
                "expired" => BuildBetaDetailsGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => BuildBetaDetailsGetInstanceFieldsBuild.IconAssetToken,
                "icons" => BuildBetaDetailsGetInstanceFieldsBuild.Icons,
                "individualTesters" => BuildBetaDetailsGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BuildBetaDetailsGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BuildBetaDetailsGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BuildBetaDetailsGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BuildBetaDetailsGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => BuildBetaDetailsGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => BuildBetaDetailsGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BuildBetaDetailsGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => BuildBetaDetailsGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}