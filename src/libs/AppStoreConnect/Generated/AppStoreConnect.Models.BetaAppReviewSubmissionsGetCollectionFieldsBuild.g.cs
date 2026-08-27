
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppReviewSubmissionsGetCollectionFieldsBuild
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
    public static class BetaAppReviewSubmissionsGetCollectionFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewSubmissionsGetCollectionFieldsBuild value)
        {
            return value switch
            {
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.App => "app",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.BetaGroups => "betaGroups",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.BuildBundles => "buildBundles",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.BuildUpload => "buildUpload",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.ExpirationDate => "expirationDate",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.Expired => "expired",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.Icons => "icons",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.IndividualTesters => "individualTesters",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.MinOsVersion => "minOsVersion",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.ProcessingState => "processingState",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.UploadedDate => "uploadedDate",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaAppReviewSubmissionsGetCollectionFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewSubmissionsGetCollectionFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.App,
                "appEncryptionDeclaration" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.BuildBundles,
                "buildUpload" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.ExpirationDate,
                "expired" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.Expired,
                "iconAssetToken" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.IconAssetToken,
                "icons" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.Icons,
                "individualTesters" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.PreReleaseVersion,
                "processingState" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.ProcessingState,
                "uploadedDate" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaAppReviewSubmissionsGetCollectionFieldsBuild.Version,
                _ => null,
            };
        }
    }
}