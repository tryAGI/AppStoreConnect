
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildUploadsGetInstanceFieldsBuild
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
    public static class BuildUploadsGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadsGetInstanceFieldsBuild value)
        {
            return value switch
            {
                BuildUploadsGetInstanceFieldsBuild.App => "app",
                BuildUploadsGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BuildUploadsGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                BuildUploadsGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BuildUploadsGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BuildUploadsGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                BuildUploadsGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                BuildUploadsGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BuildUploadsGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                BuildUploadsGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                BuildUploadsGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BuildUploadsGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BuildUploadsGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BuildUploadsGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                BuildUploadsGetInstanceFieldsBuild.Expired => "expired",
                BuildUploadsGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                BuildUploadsGetInstanceFieldsBuild.Icons => "icons",
                BuildUploadsGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                BuildUploadsGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BuildUploadsGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                BuildUploadsGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BuildUploadsGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BuildUploadsGetInstanceFieldsBuild.ProcessingState => "processingState",
                BuildUploadsGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                BuildUploadsGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BuildUploadsGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadsGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildUploadsGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => BuildUploadsGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BuildUploadsGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BuildUploadsGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BuildUploadsGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BuildUploadsGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => BuildUploadsGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BuildUploadsGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => BuildUploadsGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => BuildUploadsGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BuildUploadsGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BuildUploadsGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BuildUploadsGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BuildUploadsGetInstanceFieldsBuild.ExpirationDate,
                "expired" => BuildUploadsGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => BuildUploadsGetInstanceFieldsBuild.IconAssetToken,
                "icons" => BuildUploadsGetInstanceFieldsBuild.Icons,
                "individualTesters" => BuildUploadsGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BuildUploadsGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BuildUploadsGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BuildUploadsGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BuildUploadsGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => BuildUploadsGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => BuildUploadsGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BuildUploadsGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => BuildUploadsGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}