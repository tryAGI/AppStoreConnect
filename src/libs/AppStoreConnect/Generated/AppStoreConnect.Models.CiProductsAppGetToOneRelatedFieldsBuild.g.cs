
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsBuild
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
    public static class CiProductsAppGetToOneRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsBuild value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsBuild.App => "app",
                CiProductsAppGetToOneRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                CiProductsAppGetToOneRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                CiProductsAppGetToOneRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                CiProductsAppGetToOneRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                CiProductsAppGetToOneRelatedFieldsBuild.BetaGroups => "betaGroups",
                CiProductsAppGetToOneRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                CiProductsAppGetToOneRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                CiProductsAppGetToOneRelatedFieldsBuild.BuildBundles => "buildBundles",
                CiProductsAppGetToOneRelatedFieldsBuild.BuildUpload => "buildUpload",
                CiProductsAppGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                CiProductsAppGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                CiProductsAppGetToOneRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                CiProductsAppGetToOneRelatedFieldsBuild.ExpirationDate => "expirationDate",
                CiProductsAppGetToOneRelatedFieldsBuild.Expired => "expired",
                CiProductsAppGetToOneRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                CiProductsAppGetToOneRelatedFieldsBuild.Icons => "icons",
                CiProductsAppGetToOneRelatedFieldsBuild.IndividualTesters => "individualTesters",
                CiProductsAppGetToOneRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                CiProductsAppGetToOneRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                CiProductsAppGetToOneRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                CiProductsAppGetToOneRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                CiProductsAppGetToOneRelatedFieldsBuild.ProcessingState => "processingState",
                CiProductsAppGetToOneRelatedFieldsBuild.UploadedDate => "uploadedDate",
                CiProductsAppGetToOneRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                CiProductsAppGetToOneRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsAppGetToOneRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => CiProductsAppGetToOneRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => CiProductsAppGetToOneRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => CiProductsAppGetToOneRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => CiProductsAppGetToOneRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => CiProductsAppGetToOneRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => CiProductsAppGetToOneRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => CiProductsAppGetToOneRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => CiProductsAppGetToOneRelatedFieldsBuild.BuildBundles,
                "buildUpload" => CiProductsAppGetToOneRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => CiProductsAppGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => CiProductsAppGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => CiProductsAppGetToOneRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => CiProductsAppGetToOneRelatedFieldsBuild.ExpirationDate,
                "expired" => CiProductsAppGetToOneRelatedFieldsBuild.Expired,
                "iconAssetToken" => CiProductsAppGetToOneRelatedFieldsBuild.IconAssetToken,
                "icons" => CiProductsAppGetToOneRelatedFieldsBuild.Icons,
                "individualTesters" => CiProductsAppGetToOneRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => CiProductsAppGetToOneRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => CiProductsAppGetToOneRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => CiProductsAppGetToOneRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => CiProductsAppGetToOneRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => CiProductsAppGetToOneRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => CiProductsAppGetToOneRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => CiProductsAppGetToOneRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => CiProductsAppGetToOneRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}