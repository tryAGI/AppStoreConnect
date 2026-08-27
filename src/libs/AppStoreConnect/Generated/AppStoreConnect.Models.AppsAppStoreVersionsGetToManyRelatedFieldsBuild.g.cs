
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedFieldsBuild
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
    public static class AppsAppStoreVersionsGetToManyRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedFieldsBuild value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.App => "app",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BetaGroups => "betaGroups",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BuildBundles => "buildBundles",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BuildUpload => "buildUpload",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.ExpirationDate => "expirationDate",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.Expired => "expired",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.Icons => "icons",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.IndividualTesters => "individualTesters",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.ProcessingState => "processingState",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.UploadedDate => "uploadedDate",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                AppsAppStoreVersionsGetToManyRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BuildBundles,
                "buildUpload" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.ExpirationDate,
                "expired" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.Expired,
                "iconAssetToken" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.IconAssetToken,
                "icons" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.Icons,
                "individualTesters" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => AppsAppStoreVersionsGetToManyRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}