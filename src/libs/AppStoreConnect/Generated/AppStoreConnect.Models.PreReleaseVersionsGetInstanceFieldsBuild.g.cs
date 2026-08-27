
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreReleaseVersionsGetInstanceFieldsBuild
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
    public static class PreReleaseVersionsGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsGetInstanceFieldsBuild value)
        {
            return value switch
            {
                PreReleaseVersionsGetInstanceFieldsBuild.App => "app",
                PreReleaseVersionsGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                PreReleaseVersionsGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                PreReleaseVersionsGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                PreReleaseVersionsGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                PreReleaseVersionsGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                PreReleaseVersionsGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                PreReleaseVersionsGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                PreReleaseVersionsGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                PreReleaseVersionsGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                PreReleaseVersionsGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                PreReleaseVersionsGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                PreReleaseVersionsGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                PreReleaseVersionsGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                PreReleaseVersionsGetInstanceFieldsBuild.Expired => "expired",
                PreReleaseVersionsGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                PreReleaseVersionsGetInstanceFieldsBuild.Icons => "icons",
                PreReleaseVersionsGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                PreReleaseVersionsGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                PreReleaseVersionsGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                PreReleaseVersionsGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                PreReleaseVersionsGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                PreReleaseVersionsGetInstanceFieldsBuild.ProcessingState => "processingState",
                PreReleaseVersionsGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                PreReleaseVersionsGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                PreReleaseVersionsGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => PreReleaseVersionsGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => PreReleaseVersionsGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => PreReleaseVersionsGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => PreReleaseVersionsGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => PreReleaseVersionsGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => PreReleaseVersionsGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => PreReleaseVersionsGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => PreReleaseVersionsGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => PreReleaseVersionsGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => PreReleaseVersionsGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => PreReleaseVersionsGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => PreReleaseVersionsGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => PreReleaseVersionsGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => PreReleaseVersionsGetInstanceFieldsBuild.ExpirationDate,
                "expired" => PreReleaseVersionsGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => PreReleaseVersionsGetInstanceFieldsBuild.IconAssetToken,
                "icons" => PreReleaseVersionsGetInstanceFieldsBuild.Icons,
                "individualTesters" => PreReleaseVersionsGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => PreReleaseVersionsGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => PreReleaseVersionsGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => PreReleaseVersionsGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => PreReleaseVersionsGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => PreReleaseVersionsGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => PreReleaseVersionsGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => PreReleaseVersionsGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => PreReleaseVersionsGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}