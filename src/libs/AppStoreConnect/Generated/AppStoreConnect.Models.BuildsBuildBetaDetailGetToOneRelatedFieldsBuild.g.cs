
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsBuildBetaDetailGetToOneRelatedFieldsBuild
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
    public static class BuildsBuildBetaDetailGetToOneRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsBuildBetaDetailGetToOneRelatedFieldsBuild value)
        {
            return value switch
            {
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.App => "app",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BetaGroups => "betaGroups",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BuildBundles => "buildBundles",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BuildUpload => "buildUpload",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.ExpirationDate => "expirationDate",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.Expired => "expired",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.Icons => "icons",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.IndividualTesters => "individualTesters",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.ProcessingState => "processingState",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.UploadedDate => "uploadedDate",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsBuildBetaDetailGetToOneRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BuildBundles,
                "buildUpload" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.ExpirationDate,
                "expired" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.Expired,
                "iconAssetToken" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.IconAssetToken,
                "icons" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.Icons,
                "individualTesters" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}