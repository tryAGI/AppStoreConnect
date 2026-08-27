
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFieldsBuild
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
    public static class CiBuildRunsBuildsGetToManyRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFieldsBuild value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.App => "app",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BetaGroups => "betaGroups",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BuildBundles => "buildBundles",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BuildUpload => "buildUpload",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.ExpirationDate => "expirationDate",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.Expired => "expired",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.Icons => "icons",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.IndividualTesters => "individualTesters",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.ProcessingState => "processingState",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.UploadedDate => "uploadedDate",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BuildBundles,
                "buildUpload" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.ExpirationDate,
                "expired" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.Expired,
                "iconAssetToken" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.IconAssetToken,
                "icons" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.Icons,
                "individualTesters" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => CiBuildRunsBuildsGetToManyRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}