
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupsGetInstanceFieldsBuild
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
    public static class BetaGroupsGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsGetInstanceFieldsBuild value)
        {
            return value switch
            {
                BetaGroupsGetInstanceFieldsBuild.App => "app",
                BetaGroupsGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaGroupsGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaGroupsGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaGroupsGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaGroupsGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                BetaGroupsGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaGroupsGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaGroupsGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                BetaGroupsGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                BetaGroupsGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaGroupsGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaGroupsGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaGroupsGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                BetaGroupsGetInstanceFieldsBuild.Expired => "expired",
                BetaGroupsGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaGroupsGetInstanceFieldsBuild.Icons => "icons",
                BetaGroupsGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                BetaGroupsGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaGroupsGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                BetaGroupsGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaGroupsGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaGroupsGetInstanceFieldsBuild.ProcessingState => "processingState",
                BetaGroupsGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                BetaGroupsGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaGroupsGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaGroupsGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => BetaGroupsGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaGroupsGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaGroupsGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaGroupsGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaGroupsGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaGroupsGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaGroupsGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaGroupsGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => BetaGroupsGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaGroupsGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaGroupsGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaGroupsGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaGroupsGetInstanceFieldsBuild.ExpirationDate,
                "expired" => BetaGroupsGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => BetaGroupsGetInstanceFieldsBuild.IconAssetToken,
                "icons" => BetaGroupsGetInstanceFieldsBuild.Icons,
                "individualTesters" => BetaGroupsGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaGroupsGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaGroupsGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaGroupsGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaGroupsGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => BetaGroupsGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => BetaGroupsGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaGroupsGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaGroupsGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}