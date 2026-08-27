
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsAppStoreVersionGetToOneRelatedFieldsBuild
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
    public static class BuildsAppStoreVersionGetToOneRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppStoreVersionGetToOneRelatedFieldsBuild value)
        {
            return value switch
            {
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.App => "app",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BetaGroups => "betaGroups",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BuildBundles => "buildBundles",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BuildUpload => "buildUpload",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.ExpirationDate => "expirationDate",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.Expired => "expired",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.Icons => "icons",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.IndividualTesters => "individualTesters",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.ProcessingState => "processingState",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.UploadedDate => "uploadedDate",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BuildsAppStoreVersionGetToOneRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppStoreVersionGetToOneRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BuildBundles,
                "buildUpload" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.ExpirationDate,
                "expired" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.Expired,
                "iconAssetToken" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.IconAssetToken,
                "icons" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.Icons,
                "individualTesters" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => BuildsAppStoreVersionGetToOneRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}