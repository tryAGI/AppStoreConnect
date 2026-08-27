
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBuildUploadsGetToManyRelatedFieldsBuild
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
    public static class AppsBuildUploadsGetToManyRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBuildUploadsGetToManyRelatedFieldsBuild value)
        {
            return value switch
            {
                AppsBuildUploadsGetToManyRelatedFieldsBuild.App => "app",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.BetaGroups => "betaGroups",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.BuildBundles => "buildBundles",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.BuildUpload => "buildUpload",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.ExpirationDate => "expirationDate",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.Expired => "expired",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.Icons => "icons",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.IndividualTesters => "individualTesters",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.ProcessingState => "processingState",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.UploadedDate => "uploadedDate",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                AppsBuildUploadsGetToManyRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBuildUploadsGetToManyRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsBuildUploadsGetToManyRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => AppsBuildUploadsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => AppsBuildUploadsGetToManyRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => AppsBuildUploadsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => AppsBuildUploadsGetToManyRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => AppsBuildUploadsGetToManyRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => AppsBuildUploadsGetToManyRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => AppsBuildUploadsGetToManyRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => AppsBuildUploadsGetToManyRelatedFieldsBuild.BuildBundles,
                "buildUpload" => AppsBuildUploadsGetToManyRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => AppsBuildUploadsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => AppsBuildUploadsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => AppsBuildUploadsGetToManyRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => AppsBuildUploadsGetToManyRelatedFieldsBuild.ExpirationDate,
                "expired" => AppsBuildUploadsGetToManyRelatedFieldsBuild.Expired,
                "iconAssetToken" => AppsBuildUploadsGetToManyRelatedFieldsBuild.IconAssetToken,
                "icons" => AppsBuildUploadsGetToManyRelatedFieldsBuild.Icons,
                "individualTesters" => AppsBuildUploadsGetToManyRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => AppsBuildUploadsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => AppsBuildUploadsGetToManyRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => AppsBuildUploadsGetToManyRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => AppsBuildUploadsGetToManyRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => AppsBuildUploadsGetToManyRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => AppsBuildUploadsGetToManyRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => AppsBuildUploadsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => AppsBuildUploadsGetToManyRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}