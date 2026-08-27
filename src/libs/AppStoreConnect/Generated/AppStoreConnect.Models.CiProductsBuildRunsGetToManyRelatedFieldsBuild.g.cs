
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsBuildRunsGetToManyRelatedFieldsBuild
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
    public static class CiProductsBuildRunsGetToManyRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsBuildRunsGetToManyRelatedFieldsBuild value)
        {
            return value switch
            {
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.App => "app",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.BetaGroups => "betaGroups",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.BuildBundles => "buildBundles",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.BuildUpload => "buildUpload",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.ExpirationDate => "expirationDate",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.Expired => "expired",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.Icons => "icons",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.IndividualTesters => "individualTesters",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.ProcessingState => "processingState",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.UploadedDate => "uploadedDate",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                CiProductsBuildRunsGetToManyRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsBuildRunsGetToManyRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.BuildBundles,
                "buildUpload" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.ExpirationDate,
                "expired" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.Expired,
                "iconAssetToken" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.IconAssetToken,
                "icons" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.Icons,
                "individualTesters" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => CiProductsBuildRunsGetToManyRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}