
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFieldsBuild
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
    public static class AppsGetCollectionFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsBuild value)
        {
            return value switch
            {
                AppsGetCollectionFieldsBuild.App => "app",
                AppsGetCollectionFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                AppsGetCollectionFieldsBuild.AppStoreVersion => "appStoreVersion",
                AppsGetCollectionFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                AppsGetCollectionFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                AppsGetCollectionFieldsBuild.BetaGroups => "betaGroups",
                AppsGetCollectionFieldsBuild.BuildAudienceType => "buildAudienceType",
                AppsGetCollectionFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                AppsGetCollectionFieldsBuild.BuildBundles => "buildBundles",
                AppsGetCollectionFieldsBuild.BuildUpload => "buildUpload",
                AppsGetCollectionFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                AppsGetCollectionFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                AppsGetCollectionFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                AppsGetCollectionFieldsBuild.ExpirationDate => "expirationDate",
                AppsGetCollectionFieldsBuild.Expired => "expired",
                AppsGetCollectionFieldsBuild.IconAssetToken => "iconAssetToken",
                AppsGetCollectionFieldsBuild.Icons => "icons",
                AppsGetCollectionFieldsBuild.IndividualTesters => "individualTesters",
                AppsGetCollectionFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                AppsGetCollectionFieldsBuild.MinOsVersion => "minOsVersion",
                AppsGetCollectionFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                AppsGetCollectionFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                AppsGetCollectionFieldsBuild.ProcessingState => "processingState",
                AppsGetCollectionFieldsBuild.UploadedDate => "uploadedDate",
                AppsGetCollectionFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                AppsGetCollectionFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetCollectionFieldsBuild.App,
                "appEncryptionDeclaration" => AppsGetCollectionFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => AppsGetCollectionFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => AppsGetCollectionFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => AppsGetCollectionFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => AppsGetCollectionFieldsBuild.BetaGroups,
                "buildAudienceType" => AppsGetCollectionFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => AppsGetCollectionFieldsBuild.BuildBetaDetail,
                "buildBundles" => AppsGetCollectionFieldsBuild.BuildBundles,
                "buildUpload" => AppsGetCollectionFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => AppsGetCollectionFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => AppsGetCollectionFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => AppsGetCollectionFieldsBuild.DiagnosticSignatures,
                "expirationDate" => AppsGetCollectionFieldsBuild.ExpirationDate,
                "expired" => AppsGetCollectionFieldsBuild.Expired,
                "iconAssetToken" => AppsGetCollectionFieldsBuild.IconAssetToken,
                "icons" => AppsGetCollectionFieldsBuild.Icons,
                "individualTesters" => AppsGetCollectionFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => AppsGetCollectionFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => AppsGetCollectionFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => AppsGetCollectionFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => AppsGetCollectionFieldsBuild.PreReleaseVersion,
                "processingState" => AppsGetCollectionFieldsBuild.ProcessingState,
                "uploadedDate" => AppsGetCollectionFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => AppsGetCollectionFieldsBuild.UsesNonExemptEncryption,
                "version" => AppsGetCollectionFieldsBuild.Version,
                _ => null,
            };
        }
    }
}