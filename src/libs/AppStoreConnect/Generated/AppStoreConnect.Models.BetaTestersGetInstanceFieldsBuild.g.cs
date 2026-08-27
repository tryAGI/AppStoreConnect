
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTestersGetInstanceFieldsBuild
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
    public static class BetaTestersGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersGetInstanceFieldsBuild value)
        {
            return value switch
            {
                BetaTestersGetInstanceFieldsBuild.App => "app",
                BetaTestersGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaTestersGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaTestersGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaTestersGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaTestersGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                BetaTestersGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaTestersGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaTestersGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                BetaTestersGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                BetaTestersGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaTestersGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaTestersGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaTestersGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                BetaTestersGetInstanceFieldsBuild.Expired => "expired",
                BetaTestersGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaTestersGetInstanceFieldsBuild.Icons => "icons",
                BetaTestersGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                BetaTestersGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaTestersGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                BetaTestersGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaTestersGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaTestersGetInstanceFieldsBuild.ProcessingState => "processingState",
                BetaTestersGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                BetaTestersGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaTestersGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaTestersGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => BetaTestersGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaTestersGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaTestersGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaTestersGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaTestersGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaTestersGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaTestersGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaTestersGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => BetaTestersGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaTestersGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaTestersGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaTestersGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaTestersGetInstanceFieldsBuild.ExpirationDate,
                "expired" => BetaTestersGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => BetaTestersGetInstanceFieldsBuild.IconAssetToken,
                "icons" => BetaTestersGetInstanceFieldsBuild.Icons,
                "individualTesters" => BetaTestersGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaTestersGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaTestersGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaTestersGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaTestersGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => BetaTestersGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => BetaTestersGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaTestersGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaTestersGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}