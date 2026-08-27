
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaBuildLocalizationsGetInstanceFieldsBuild
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
    public static class BetaBuildLocalizationsGetInstanceFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBuildLocalizationsGetInstanceFieldsBuild value)
        {
            return value switch
            {
                BetaBuildLocalizationsGetInstanceFieldsBuild.App => "app",
                BetaBuildLocalizationsGetInstanceFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaBuildLocalizationsGetInstanceFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaBuildLocalizationsGetInstanceFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaBuildLocalizationsGetInstanceFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaBuildLocalizationsGetInstanceFieldsBuild.BetaGroups => "betaGroups",
                BetaBuildLocalizationsGetInstanceFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaBuildLocalizationsGetInstanceFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaBuildLocalizationsGetInstanceFieldsBuild.BuildBundles => "buildBundles",
                BetaBuildLocalizationsGetInstanceFieldsBuild.BuildUpload => "buildUpload",
                BetaBuildLocalizationsGetInstanceFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaBuildLocalizationsGetInstanceFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaBuildLocalizationsGetInstanceFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaBuildLocalizationsGetInstanceFieldsBuild.ExpirationDate => "expirationDate",
                BetaBuildLocalizationsGetInstanceFieldsBuild.Expired => "expired",
                BetaBuildLocalizationsGetInstanceFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaBuildLocalizationsGetInstanceFieldsBuild.Icons => "icons",
                BetaBuildLocalizationsGetInstanceFieldsBuild.IndividualTesters => "individualTesters",
                BetaBuildLocalizationsGetInstanceFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaBuildLocalizationsGetInstanceFieldsBuild.MinOsVersion => "minOsVersion",
                BetaBuildLocalizationsGetInstanceFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaBuildLocalizationsGetInstanceFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaBuildLocalizationsGetInstanceFieldsBuild.ProcessingState => "processingState",
                BetaBuildLocalizationsGetInstanceFieldsBuild.UploadedDate => "uploadedDate",
                BetaBuildLocalizationsGetInstanceFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaBuildLocalizationsGetInstanceFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBuildLocalizationsGetInstanceFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaBuildLocalizationsGetInstanceFieldsBuild.App,
                "appEncryptionDeclaration" => BetaBuildLocalizationsGetInstanceFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaBuildLocalizationsGetInstanceFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaBuildLocalizationsGetInstanceFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaBuildLocalizationsGetInstanceFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaBuildLocalizationsGetInstanceFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaBuildLocalizationsGetInstanceFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaBuildLocalizationsGetInstanceFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaBuildLocalizationsGetInstanceFieldsBuild.BuildBundles,
                "buildUpload" => BetaBuildLocalizationsGetInstanceFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaBuildLocalizationsGetInstanceFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaBuildLocalizationsGetInstanceFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaBuildLocalizationsGetInstanceFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaBuildLocalizationsGetInstanceFieldsBuild.ExpirationDate,
                "expired" => BetaBuildLocalizationsGetInstanceFieldsBuild.Expired,
                "iconAssetToken" => BetaBuildLocalizationsGetInstanceFieldsBuild.IconAssetToken,
                "icons" => BetaBuildLocalizationsGetInstanceFieldsBuild.Icons,
                "individualTesters" => BetaBuildLocalizationsGetInstanceFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaBuildLocalizationsGetInstanceFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaBuildLocalizationsGetInstanceFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaBuildLocalizationsGetInstanceFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaBuildLocalizationsGetInstanceFieldsBuild.PreReleaseVersion,
                "processingState" => BetaBuildLocalizationsGetInstanceFieldsBuild.ProcessingState,
                "uploadedDate" => BetaBuildLocalizationsGetInstanceFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaBuildLocalizationsGetInstanceFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaBuildLocalizationsGetInstanceFieldsBuild.Version,
                _ => null,
            };
        }
    }
}