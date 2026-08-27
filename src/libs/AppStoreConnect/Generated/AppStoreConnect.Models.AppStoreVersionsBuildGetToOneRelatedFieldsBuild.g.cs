
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsBuildGetToOneRelatedFieldsBuild
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
    public static class AppStoreVersionsBuildGetToOneRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsBuildGetToOneRelatedFieldsBuild value)
        {
            return value switch
            {
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.App => "app",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BetaGroups => "betaGroups",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BuildBundles => "buildBundles",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BuildUpload => "buildUpload",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.ExpirationDate => "expirationDate",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.Expired => "expired",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.Icons => "icons",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.IndividualTesters => "individualTesters",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.ProcessingState => "processingState",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.UploadedDate => "uploadedDate",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                AppStoreVersionsBuildGetToOneRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsBuildGetToOneRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BuildBundles,
                "buildUpload" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.ExpirationDate,
                "expired" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.Expired,
                "iconAssetToken" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.IconAssetToken,
                "icons" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.Icons,
                "individualTesters" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => AppStoreVersionsBuildGetToOneRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}