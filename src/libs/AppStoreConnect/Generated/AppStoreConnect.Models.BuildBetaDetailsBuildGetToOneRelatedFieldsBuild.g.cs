
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedFieldsBuild
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
    public static class BuildBetaDetailsBuildGetToOneRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedFieldsBuild value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.App => "app",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BetaGroups => "betaGroups",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BuildBundles => "buildBundles",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BuildUpload => "buildUpload",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.ExpirationDate => "expirationDate",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.Expired => "expired",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.Icons => "icons",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.IndividualTesters => "individualTesters",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.ProcessingState => "processingState",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.UploadedDate => "uploadedDate",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BuildBundles,
                "buildUpload" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.ExpirationDate,
                "expired" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.Expired,
                "iconAssetToken" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.IconAssetToken,
                "icons" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.Icons,
                "individualTesters" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}