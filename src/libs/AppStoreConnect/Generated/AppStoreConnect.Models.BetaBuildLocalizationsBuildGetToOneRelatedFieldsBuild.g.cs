
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild
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
    public static class BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild value)
        {
            return value switch
            {
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.App => "app",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BetaGroups => "betaGroups",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BuildBundles => "buildBundles",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BuildUpload => "buildUpload",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.ExpirationDate => "expirationDate",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.Expired => "expired",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.Icons => "icons",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.IndividualTesters => "individualTesters",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.ProcessingState => "processingState",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.UploadedDate => "uploadedDate",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BuildBundles,
                "buildUpload" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.ExpirationDate,
                "expired" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.Expired,
                "iconAssetToken" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.IconAssetToken,
                "icons" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.Icons,
                "individualTesters" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaBuildLocalizationsBuildGetToOneRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}