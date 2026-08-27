
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetCollectionFieldsBuild
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
    public static class BuildsGetCollectionFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFieldsBuild value)
        {
            return value switch
            {
                BuildsGetCollectionFieldsBuild.App => "app",
                BuildsGetCollectionFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BuildsGetCollectionFieldsBuild.AppStoreVersion => "appStoreVersion",
                BuildsGetCollectionFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BuildsGetCollectionFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BuildsGetCollectionFieldsBuild.BetaGroups => "betaGroups",
                BuildsGetCollectionFieldsBuild.BuildAudienceType => "buildAudienceType",
                BuildsGetCollectionFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BuildsGetCollectionFieldsBuild.BuildBundles => "buildBundles",
                BuildsGetCollectionFieldsBuild.BuildUpload => "buildUpload",
                BuildsGetCollectionFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BuildsGetCollectionFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BuildsGetCollectionFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BuildsGetCollectionFieldsBuild.ExpirationDate => "expirationDate",
                BuildsGetCollectionFieldsBuild.Expired => "expired",
                BuildsGetCollectionFieldsBuild.IconAssetToken => "iconAssetToken",
                BuildsGetCollectionFieldsBuild.Icons => "icons",
                BuildsGetCollectionFieldsBuild.IndividualTesters => "individualTesters",
                BuildsGetCollectionFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BuildsGetCollectionFieldsBuild.MinOsVersion => "minOsVersion",
                BuildsGetCollectionFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BuildsGetCollectionFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BuildsGetCollectionFieldsBuild.ProcessingState => "processingState",
                BuildsGetCollectionFieldsBuild.UploadedDate => "uploadedDate",
                BuildsGetCollectionFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BuildsGetCollectionFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsGetCollectionFieldsBuild.App,
                "appEncryptionDeclaration" => BuildsGetCollectionFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BuildsGetCollectionFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BuildsGetCollectionFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BuildsGetCollectionFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BuildsGetCollectionFieldsBuild.BetaGroups,
                "buildAudienceType" => BuildsGetCollectionFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BuildsGetCollectionFieldsBuild.BuildBetaDetail,
                "buildBundles" => BuildsGetCollectionFieldsBuild.BuildBundles,
                "buildUpload" => BuildsGetCollectionFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BuildsGetCollectionFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BuildsGetCollectionFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BuildsGetCollectionFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BuildsGetCollectionFieldsBuild.ExpirationDate,
                "expired" => BuildsGetCollectionFieldsBuild.Expired,
                "iconAssetToken" => BuildsGetCollectionFieldsBuild.IconAssetToken,
                "icons" => BuildsGetCollectionFieldsBuild.Icons,
                "individualTesters" => BuildsGetCollectionFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BuildsGetCollectionFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BuildsGetCollectionFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BuildsGetCollectionFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BuildsGetCollectionFieldsBuild.PreReleaseVersion,
                "processingState" => BuildsGetCollectionFieldsBuild.ProcessingState,
                "uploadedDate" => BuildsGetCollectionFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BuildsGetCollectionFieldsBuild.UsesNonExemptEncryption,
                "version" => BuildsGetCollectionFieldsBuild.Version,
                _ => null,
            };
        }
    }
}