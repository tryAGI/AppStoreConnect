
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTestersGetCollectionFieldsBuild
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
    public static class BetaTestersGetCollectionFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersGetCollectionFieldsBuild value)
        {
            return value switch
            {
                BetaTestersGetCollectionFieldsBuild.App => "app",
                BetaTestersGetCollectionFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaTestersGetCollectionFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaTestersGetCollectionFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaTestersGetCollectionFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaTestersGetCollectionFieldsBuild.BetaGroups => "betaGroups",
                BetaTestersGetCollectionFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaTestersGetCollectionFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaTestersGetCollectionFieldsBuild.BuildBundles => "buildBundles",
                BetaTestersGetCollectionFieldsBuild.BuildUpload => "buildUpload",
                BetaTestersGetCollectionFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaTestersGetCollectionFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaTestersGetCollectionFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaTestersGetCollectionFieldsBuild.ExpirationDate => "expirationDate",
                BetaTestersGetCollectionFieldsBuild.Expired => "expired",
                BetaTestersGetCollectionFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaTestersGetCollectionFieldsBuild.Icons => "icons",
                BetaTestersGetCollectionFieldsBuild.IndividualTesters => "individualTesters",
                BetaTestersGetCollectionFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaTestersGetCollectionFieldsBuild.MinOsVersion => "minOsVersion",
                BetaTestersGetCollectionFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaTestersGetCollectionFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaTestersGetCollectionFieldsBuild.ProcessingState => "processingState",
                BetaTestersGetCollectionFieldsBuild.UploadedDate => "uploadedDate",
                BetaTestersGetCollectionFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaTestersGetCollectionFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersGetCollectionFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaTestersGetCollectionFieldsBuild.App,
                "appEncryptionDeclaration" => BetaTestersGetCollectionFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaTestersGetCollectionFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaTestersGetCollectionFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaTestersGetCollectionFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaTestersGetCollectionFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaTestersGetCollectionFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaTestersGetCollectionFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaTestersGetCollectionFieldsBuild.BuildBundles,
                "buildUpload" => BetaTestersGetCollectionFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaTestersGetCollectionFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaTestersGetCollectionFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaTestersGetCollectionFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaTestersGetCollectionFieldsBuild.ExpirationDate,
                "expired" => BetaTestersGetCollectionFieldsBuild.Expired,
                "iconAssetToken" => BetaTestersGetCollectionFieldsBuild.IconAssetToken,
                "icons" => BetaTestersGetCollectionFieldsBuild.Icons,
                "individualTesters" => BetaTestersGetCollectionFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaTestersGetCollectionFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaTestersGetCollectionFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaTestersGetCollectionFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaTestersGetCollectionFieldsBuild.PreReleaseVersion,
                "processingState" => BetaTestersGetCollectionFieldsBuild.ProcessingState,
                "uploadedDate" => BetaTestersGetCollectionFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaTestersGetCollectionFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaTestersGetCollectionFieldsBuild.Version,
                _ => null,
            };
        }
    }
}