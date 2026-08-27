
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsGetInstanceFieldsBuild
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
    public static class CiBuildRunsGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsGetInstanceFieldsBuild value)
        {
            return value switch
            {
                CiBuildRunsGetInstanceFieldsBuild.App => "app",
                CiBuildRunsGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                CiBuildRunsGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                CiBuildRunsGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                CiBuildRunsGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                CiBuildRunsGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                CiBuildRunsGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                CiBuildRunsGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                CiBuildRunsGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                CiBuildRunsGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                CiBuildRunsGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                CiBuildRunsGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                CiBuildRunsGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                CiBuildRunsGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                CiBuildRunsGetInstanceFieldsBuild.Expired => "expired",
                CiBuildRunsGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                CiBuildRunsGetInstanceFieldsBuild.Icons => "icons",
                CiBuildRunsGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                CiBuildRunsGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                CiBuildRunsGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                CiBuildRunsGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                CiBuildRunsGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                CiBuildRunsGetInstanceFieldsBuild.ProcessingState => "processingState",
                CiBuildRunsGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                CiBuildRunsGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                CiBuildRunsGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiBuildRunsGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => CiBuildRunsGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => CiBuildRunsGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => CiBuildRunsGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => CiBuildRunsGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => CiBuildRunsGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => CiBuildRunsGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => CiBuildRunsGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => CiBuildRunsGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => CiBuildRunsGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => CiBuildRunsGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => CiBuildRunsGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => CiBuildRunsGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => CiBuildRunsGetInstanceFieldsBuild.ExpirationDate,
                "expired" => CiBuildRunsGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => CiBuildRunsGetInstanceFieldsBuild.IconAssetToken,
                "icons" => CiBuildRunsGetInstanceFieldsBuild.Icons,
                "individualTesters" => CiBuildRunsGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => CiBuildRunsGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => CiBuildRunsGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => CiBuildRunsGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => CiBuildRunsGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => CiBuildRunsGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => CiBuildRunsGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => CiBuildRunsGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => CiBuildRunsGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}