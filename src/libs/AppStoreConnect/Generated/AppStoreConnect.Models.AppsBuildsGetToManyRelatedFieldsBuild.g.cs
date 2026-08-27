
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBuildsGetToManyRelatedFieldsBuild
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
    public static class AppsBuildsGetToManyRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBuildsGetToManyRelatedFieldsBuild value)
        {
            return value switch
            {
                AppsBuildsGetToManyRelatedFieldsBuild.App => "app",
                AppsBuildsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                AppsBuildsGetToManyRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                AppsBuildsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                AppsBuildsGetToManyRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                AppsBuildsGetToManyRelatedFieldsBuild.BetaGroups => "betaGroups",
                AppsBuildsGetToManyRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                AppsBuildsGetToManyRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                AppsBuildsGetToManyRelatedFieldsBuild.BuildBundles => "buildBundles",
                AppsBuildsGetToManyRelatedFieldsBuild.BuildUpload => "buildUpload",
                AppsBuildsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                AppsBuildsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                AppsBuildsGetToManyRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                AppsBuildsGetToManyRelatedFieldsBuild.ExpirationDate => "expirationDate",
                AppsBuildsGetToManyRelatedFieldsBuild.Expired => "expired",
                AppsBuildsGetToManyRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                AppsBuildsGetToManyRelatedFieldsBuild.Icons => "icons",
                AppsBuildsGetToManyRelatedFieldsBuild.IndividualTesters => "individualTesters",
                AppsBuildsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                AppsBuildsGetToManyRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                AppsBuildsGetToManyRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                AppsBuildsGetToManyRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                AppsBuildsGetToManyRelatedFieldsBuild.ProcessingState => "processingState",
                AppsBuildsGetToManyRelatedFieldsBuild.UploadedDate => "uploadedDate",
                AppsBuildsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                AppsBuildsGetToManyRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBuildsGetToManyRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsBuildsGetToManyRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => AppsBuildsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => AppsBuildsGetToManyRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => AppsBuildsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => AppsBuildsGetToManyRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => AppsBuildsGetToManyRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => AppsBuildsGetToManyRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => AppsBuildsGetToManyRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => AppsBuildsGetToManyRelatedFieldsBuild.BuildBundles,
                "buildUpload" => AppsBuildsGetToManyRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => AppsBuildsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => AppsBuildsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => AppsBuildsGetToManyRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => AppsBuildsGetToManyRelatedFieldsBuild.ExpirationDate,
                "expired" => AppsBuildsGetToManyRelatedFieldsBuild.Expired,
                "iconAssetToken" => AppsBuildsGetToManyRelatedFieldsBuild.IconAssetToken,
                "icons" => AppsBuildsGetToManyRelatedFieldsBuild.Icons,
                "individualTesters" => AppsBuildsGetToManyRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => AppsBuildsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => AppsBuildsGetToManyRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => AppsBuildsGetToManyRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => AppsBuildsGetToManyRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => AppsBuildsGetToManyRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => AppsBuildsGetToManyRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => AppsBuildsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => AppsBuildsGetToManyRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}