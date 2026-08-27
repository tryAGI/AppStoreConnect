
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppReviewSubmissionsGetInstanceFieldsBuild
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
    public static class BetaAppReviewSubmissionsGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewSubmissionsGetInstanceFieldsBuild value)
        {
            return value switch
            {
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.App => "app",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.Expired => "expired",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.Icons => "icons",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.ProcessingState => "processingState",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaAppReviewSubmissionsGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewSubmissionsGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.ExpirationDate,
                "expired" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.IconAssetToken,
                "icons" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.Icons,
                "individualTesters" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaAppReviewSubmissionsGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}