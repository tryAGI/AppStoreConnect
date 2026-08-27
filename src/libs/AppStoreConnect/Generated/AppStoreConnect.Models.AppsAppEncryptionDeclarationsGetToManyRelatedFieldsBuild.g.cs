
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild
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
    public static class AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild value)
        {
            return value switch
            {
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.App => "app",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BetaGroups => "betaGroups",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BuildBundles => "buildBundles",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BuildUpload => "buildUpload",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.ExpirationDate => "expirationDate",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.Expired => "expired",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.Icons => "icons",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.IndividualTesters => "individualTesters",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.ProcessingState => "processingState",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.UploadedDate => "uploadedDate",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BuildBundles,
                "buildUpload" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.ExpirationDate,
                "expired" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.Expired,
                "iconAssetToken" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.IconAssetToken,
                "icons" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.Icons,
                "individualTesters" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}