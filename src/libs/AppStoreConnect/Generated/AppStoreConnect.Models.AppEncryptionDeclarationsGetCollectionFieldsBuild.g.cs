
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationsGetCollectionFieldsBuild
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
    public static class AppEncryptionDeclarationsGetCollectionFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationsGetCollectionFieldsBuild value)
        {
            return value switch
            {
                AppEncryptionDeclarationsGetCollectionFieldsBuild.App => "app",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.AppStoreVersion => "appStoreVersion",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.BetaGroups => "betaGroups",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.BuildAudienceType => "buildAudienceType",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.BuildBundles => "buildBundles",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.BuildUpload => "buildUpload",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.ExpirationDate => "expirationDate",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.Expired => "expired",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.IconAssetToken => "iconAssetToken",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.Icons => "icons",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.IndividualTesters => "individualTesters",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.MinOsVersion => "minOsVersion",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.ProcessingState => "processingState",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.UploadedDate => "uploadedDate",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                AppEncryptionDeclarationsGetCollectionFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationsGetCollectionFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppEncryptionDeclarationsGetCollectionFieldsBuild.App,
                "appEncryptionDeclaration" => AppEncryptionDeclarationsGetCollectionFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => AppEncryptionDeclarationsGetCollectionFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => AppEncryptionDeclarationsGetCollectionFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => AppEncryptionDeclarationsGetCollectionFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => AppEncryptionDeclarationsGetCollectionFieldsBuild.BetaGroups,
                "buildAudienceType" => AppEncryptionDeclarationsGetCollectionFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => AppEncryptionDeclarationsGetCollectionFieldsBuild.BuildBetaDetail,
                "buildBundles" => AppEncryptionDeclarationsGetCollectionFieldsBuild.BuildBundles,
                "buildUpload" => AppEncryptionDeclarationsGetCollectionFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => AppEncryptionDeclarationsGetCollectionFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => AppEncryptionDeclarationsGetCollectionFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => AppEncryptionDeclarationsGetCollectionFieldsBuild.DiagnosticSignatures,
                "expirationDate" => AppEncryptionDeclarationsGetCollectionFieldsBuild.ExpirationDate,
                "expired" => AppEncryptionDeclarationsGetCollectionFieldsBuild.Expired,
                "iconAssetToken" => AppEncryptionDeclarationsGetCollectionFieldsBuild.IconAssetToken,
                "icons" => AppEncryptionDeclarationsGetCollectionFieldsBuild.Icons,
                "individualTesters" => AppEncryptionDeclarationsGetCollectionFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => AppEncryptionDeclarationsGetCollectionFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => AppEncryptionDeclarationsGetCollectionFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => AppEncryptionDeclarationsGetCollectionFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => AppEncryptionDeclarationsGetCollectionFieldsBuild.PreReleaseVersion,
                "processingState" => AppEncryptionDeclarationsGetCollectionFieldsBuild.ProcessingState,
                "uploadedDate" => AppEncryptionDeclarationsGetCollectionFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => AppEncryptionDeclarationsGetCollectionFieldsBuild.UsesNonExemptEncryption,
                "version" => AppEncryptionDeclarationsGetCollectionFieldsBuild.Version,
                _ => null,
            };
        }
    }
}