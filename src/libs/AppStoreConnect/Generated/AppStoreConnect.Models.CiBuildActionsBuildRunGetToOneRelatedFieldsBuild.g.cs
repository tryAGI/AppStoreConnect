
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildActionsBuildRunGetToOneRelatedFieldsBuild
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
    public static class CiBuildActionsBuildRunGetToOneRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionsBuildRunGetToOneRelatedFieldsBuild value)
        {
            return value switch
            {
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.App => "app",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BetaGroups => "betaGroups",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BuildBundles => "buildBundles",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BuildUpload => "buildUpload",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.ExpirationDate => "expirationDate",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.Expired => "expired",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.Icons => "icons",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.IndividualTesters => "individualTesters",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.ProcessingState => "processingState",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.UploadedDate => "uploadedDate",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionsBuildRunGetToOneRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BuildBundles,
                "buildUpload" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.ExpirationDate,
                "expired" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.Expired,
                "iconAssetToken" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.IconAssetToken,
                "icons" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.Icons,
                "individualTesters" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => CiBuildActionsBuildRunGetToOneRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}