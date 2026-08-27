
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild
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
    public static class PreReleaseVersionsBuildsGetToManyRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild value)
        {
            return value switch
            {
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.App => "app",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BetaGroups => "betaGroups",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BuildBundles => "buildBundles",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BuildUpload => "buildUpload",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.ExpirationDate => "expirationDate",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.Expired => "expired",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.Icons => "icons",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.IndividualTesters => "individualTesters",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.ProcessingState => "processingState",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.UploadedDate => "uploadedDate",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BuildBundles,
                "buildUpload" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.ExpirationDate,
                "expired" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.Expired,
                "iconAssetToken" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.IconAssetToken,
                "icons" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.Icons,
                "individualTesters" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => PreReleaseVersionsBuildsGetToManyRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}