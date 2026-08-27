
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild
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
    public static class BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild value)
        {
            return value switch
            {
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.App => "app",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BetaGroups => "betaGroups",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BuildBundles => "buildBundles",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BuildUpload => "buildUpload",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.ExpirationDate => "expirationDate",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.Expired => "expired",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.Icons => "icons",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.IndividualTesters => "individualTesters",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.ProcessingState => "processingState",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.UploadedDate => "uploadedDate",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BuildBundles,
                "buildUpload" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.ExpirationDate,
                "expired" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.Expired,
                "iconAssetToken" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.IconAssetToken,
                "icons" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.Icons,
                "individualTesters" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaAppReviewSubmissionsBuildGetToOneRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}