
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PreReleaseVersionsGetCollectionFieldsBuild
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
    public static class PreReleaseVersionsGetCollectionFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsGetCollectionFieldsBuild value)
        {
            return value switch
            {
                PreReleaseVersionsGetCollectionFieldsBuild.App => "app",
                PreReleaseVersionsGetCollectionFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                PreReleaseVersionsGetCollectionFieldsBuild.AppStoreVersion => "appStoreVersion",
                PreReleaseVersionsGetCollectionFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                PreReleaseVersionsGetCollectionFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                PreReleaseVersionsGetCollectionFieldsBuild.BetaGroups => "betaGroups",
                PreReleaseVersionsGetCollectionFieldsBuild.BuildAudienceType => "buildAudienceType",
                PreReleaseVersionsGetCollectionFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                PreReleaseVersionsGetCollectionFieldsBuild.BuildBundles => "buildBundles",
                PreReleaseVersionsGetCollectionFieldsBuild.BuildUpload => "buildUpload",
                PreReleaseVersionsGetCollectionFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                PreReleaseVersionsGetCollectionFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                PreReleaseVersionsGetCollectionFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                PreReleaseVersionsGetCollectionFieldsBuild.ExpirationDate => "expirationDate",
                PreReleaseVersionsGetCollectionFieldsBuild.Expired => "expired",
                PreReleaseVersionsGetCollectionFieldsBuild.IconAssetToken => "iconAssetToken",
                PreReleaseVersionsGetCollectionFieldsBuild.Icons => "icons",
                PreReleaseVersionsGetCollectionFieldsBuild.IndividualTesters => "individualTesters",
                PreReleaseVersionsGetCollectionFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                PreReleaseVersionsGetCollectionFieldsBuild.MinOsVersion => "minOsVersion",
                PreReleaseVersionsGetCollectionFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                PreReleaseVersionsGetCollectionFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                PreReleaseVersionsGetCollectionFieldsBuild.ProcessingState => "processingState",
                PreReleaseVersionsGetCollectionFieldsBuild.UploadedDate => "uploadedDate",
                PreReleaseVersionsGetCollectionFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                PreReleaseVersionsGetCollectionFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsGetCollectionFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => PreReleaseVersionsGetCollectionFieldsBuild.App,
                "appEncryptionDeclaration" => PreReleaseVersionsGetCollectionFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => PreReleaseVersionsGetCollectionFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => PreReleaseVersionsGetCollectionFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => PreReleaseVersionsGetCollectionFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => PreReleaseVersionsGetCollectionFieldsBuild.BetaGroups,
                "buildAudienceType" => PreReleaseVersionsGetCollectionFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => PreReleaseVersionsGetCollectionFieldsBuild.BuildBetaDetail,
                "buildBundles" => PreReleaseVersionsGetCollectionFieldsBuild.BuildBundles,
                "buildUpload" => PreReleaseVersionsGetCollectionFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => PreReleaseVersionsGetCollectionFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => PreReleaseVersionsGetCollectionFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => PreReleaseVersionsGetCollectionFieldsBuild.DiagnosticSignatures,
                "expirationDate" => PreReleaseVersionsGetCollectionFieldsBuild.ExpirationDate,
                "expired" => PreReleaseVersionsGetCollectionFieldsBuild.Expired,
                "iconAssetToken" => PreReleaseVersionsGetCollectionFieldsBuild.IconAssetToken,
                "icons" => PreReleaseVersionsGetCollectionFieldsBuild.Icons,
                "individualTesters" => PreReleaseVersionsGetCollectionFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => PreReleaseVersionsGetCollectionFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => PreReleaseVersionsGetCollectionFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => PreReleaseVersionsGetCollectionFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => PreReleaseVersionsGetCollectionFieldsBuild.PreReleaseVersion,
                "processingState" => PreReleaseVersionsGetCollectionFieldsBuild.ProcessingState,
                "uploadedDate" => PreReleaseVersionsGetCollectionFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => PreReleaseVersionsGetCollectionFieldsBuild.UsesNonExemptEncryption,
                "version" => PreReleaseVersionsGetCollectionFieldsBuild.Version,
                _ => null,
            };
        }
    }
}