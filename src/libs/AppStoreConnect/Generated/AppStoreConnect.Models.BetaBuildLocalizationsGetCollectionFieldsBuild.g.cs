
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaBuildLocalizationsGetCollectionFieldsBuild
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
    public static class BetaBuildLocalizationsGetCollectionFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBuildLocalizationsGetCollectionFieldsBuild value)
        {
            return value switch
            {
                BetaBuildLocalizationsGetCollectionFieldsBuild.App => "app",
                BetaBuildLocalizationsGetCollectionFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaBuildLocalizationsGetCollectionFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaBuildLocalizationsGetCollectionFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaBuildLocalizationsGetCollectionFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaBuildLocalizationsGetCollectionFieldsBuild.BetaGroups => "betaGroups",
                BetaBuildLocalizationsGetCollectionFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaBuildLocalizationsGetCollectionFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaBuildLocalizationsGetCollectionFieldsBuild.BuildBundles => "buildBundles",
                BetaBuildLocalizationsGetCollectionFieldsBuild.BuildUpload => "buildUpload",
                BetaBuildLocalizationsGetCollectionFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaBuildLocalizationsGetCollectionFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaBuildLocalizationsGetCollectionFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaBuildLocalizationsGetCollectionFieldsBuild.ExpirationDate => "expirationDate",
                BetaBuildLocalizationsGetCollectionFieldsBuild.Expired => "expired",
                BetaBuildLocalizationsGetCollectionFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaBuildLocalizationsGetCollectionFieldsBuild.Icons => "icons",
                BetaBuildLocalizationsGetCollectionFieldsBuild.IndividualTesters => "individualTesters",
                BetaBuildLocalizationsGetCollectionFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaBuildLocalizationsGetCollectionFieldsBuild.MinOsVersion => "minOsVersion",
                BetaBuildLocalizationsGetCollectionFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaBuildLocalizationsGetCollectionFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaBuildLocalizationsGetCollectionFieldsBuild.ProcessingState => "processingState",
                BetaBuildLocalizationsGetCollectionFieldsBuild.UploadedDate => "uploadedDate",
                BetaBuildLocalizationsGetCollectionFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaBuildLocalizationsGetCollectionFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBuildLocalizationsGetCollectionFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaBuildLocalizationsGetCollectionFieldsBuild.App,
                "appEncryptionDeclaration" => BetaBuildLocalizationsGetCollectionFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaBuildLocalizationsGetCollectionFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaBuildLocalizationsGetCollectionFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaBuildLocalizationsGetCollectionFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaBuildLocalizationsGetCollectionFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaBuildLocalizationsGetCollectionFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaBuildLocalizationsGetCollectionFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaBuildLocalizationsGetCollectionFieldsBuild.BuildBundles,
                "buildUpload" => BetaBuildLocalizationsGetCollectionFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaBuildLocalizationsGetCollectionFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaBuildLocalizationsGetCollectionFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaBuildLocalizationsGetCollectionFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaBuildLocalizationsGetCollectionFieldsBuild.ExpirationDate,
                "expired" => BetaBuildLocalizationsGetCollectionFieldsBuild.Expired,
                "iconAssetToken" => BetaBuildLocalizationsGetCollectionFieldsBuild.IconAssetToken,
                "icons" => BetaBuildLocalizationsGetCollectionFieldsBuild.Icons,
                "individualTesters" => BetaBuildLocalizationsGetCollectionFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaBuildLocalizationsGetCollectionFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaBuildLocalizationsGetCollectionFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaBuildLocalizationsGetCollectionFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaBuildLocalizationsGetCollectionFieldsBuild.PreReleaseVersion,
                "processingState" => BetaBuildLocalizationsGetCollectionFieldsBuild.ProcessingState,
                "uploadedDate" => BetaBuildLocalizationsGetCollectionFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaBuildLocalizationsGetCollectionFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaBuildLocalizationsGetCollectionFieldsBuild.Version,
                _ => null,
            };
        }
    }
}