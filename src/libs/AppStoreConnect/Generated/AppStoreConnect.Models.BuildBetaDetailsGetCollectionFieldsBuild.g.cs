
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaDetailsGetCollectionFieldsBuild
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
    public static class BuildBetaDetailsGetCollectionFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsGetCollectionFieldsBuild value)
        {
            return value switch
            {
                BuildBetaDetailsGetCollectionFieldsBuild.App => "app",
                BuildBetaDetailsGetCollectionFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BuildBetaDetailsGetCollectionFieldsBuild.AppStoreVersion => "appStoreVersion",
                BuildBetaDetailsGetCollectionFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BuildBetaDetailsGetCollectionFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BuildBetaDetailsGetCollectionFieldsBuild.BetaGroups => "betaGroups",
                BuildBetaDetailsGetCollectionFieldsBuild.BuildAudienceType => "buildAudienceType",
                BuildBetaDetailsGetCollectionFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BuildBetaDetailsGetCollectionFieldsBuild.BuildBundles => "buildBundles",
                BuildBetaDetailsGetCollectionFieldsBuild.BuildUpload => "buildUpload",
                BuildBetaDetailsGetCollectionFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BuildBetaDetailsGetCollectionFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BuildBetaDetailsGetCollectionFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BuildBetaDetailsGetCollectionFieldsBuild.ExpirationDate => "expirationDate",
                BuildBetaDetailsGetCollectionFieldsBuild.Expired => "expired",
                BuildBetaDetailsGetCollectionFieldsBuild.IconAssetToken => "iconAssetToken",
                BuildBetaDetailsGetCollectionFieldsBuild.Icons => "icons",
                BuildBetaDetailsGetCollectionFieldsBuild.IndividualTesters => "individualTesters",
                BuildBetaDetailsGetCollectionFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BuildBetaDetailsGetCollectionFieldsBuild.MinOsVersion => "minOsVersion",
                BuildBetaDetailsGetCollectionFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BuildBetaDetailsGetCollectionFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BuildBetaDetailsGetCollectionFieldsBuild.ProcessingState => "processingState",
                BuildBetaDetailsGetCollectionFieldsBuild.UploadedDate => "uploadedDate",
                BuildBetaDetailsGetCollectionFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BuildBetaDetailsGetCollectionFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsGetCollectionFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildBetaDetailsGetCollectionFieldsBuild.App,
                "appEncryptionDeclaration" => BuildBetaDetailsGetCollectionFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BuildBetaDetailsGetCollectionFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BuildBetaDetailsGetCollectionFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BuildBetaDetailsGetCollectionFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BuildBetaDetailsGetCollectionFieldsBuild.BetaGroups,
                "buildAudienceType" => BuildBetaDetailsGetCollectionFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BuildBetaDetailsGetCollectionFieldsBuild.BuildBetaDetail,
                "buildBundles" => BuildBetaDetailsGetCollectionFieldsBuild.BuildBundles,
                "buildUpload" => BuildBetaDetailsGetCollectionFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BuildBetaDetailsGetCollectionFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BuildBetaDetailsGetCollectionFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BuildBetaDetailsGetCollectionFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BuildBetaDetailsGetCollectionFieldsBuild.ExpirationDate,
                "expired" => BuildBetaDetailsGetCollectionFieldsBuild.Expired,
                "iconAssetToken" => BuildBetaDetailsGetCollectionFieldsBuild.IconAssetToken,
                "icons" => BuildBetaDetailsGetCollectionFieldsBuild.Icons,
                "individualTesters" => BuildBetaDetailsGetCollectionFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BuildBetaDetailsGetCollectionFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BuildBetaDetailsGetCollectionFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BuildBetaDetailsGetCollectionFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BuildBetaDetailsGetCollectionFieldsBuild.PreReleaseVersion,
                "processingState" => BuildBetaDetailsGetCollectionFieldsBuild.ProcessingState,
                "uploadedDate" => BuildBetaDetailsGetCollectionFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BuildBetaDetailsGetCollectionFieldsBuild.UsesNonExemptEncryption,
                "version" => BuildBetaDetailsGetCollectionFieldsBuild.Version,
                _ => null,
            };
        }
    }
}