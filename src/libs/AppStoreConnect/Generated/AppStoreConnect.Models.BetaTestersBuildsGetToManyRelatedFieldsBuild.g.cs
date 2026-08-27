
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTestersBuildsGetToManyRelatedFieldsBuild
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
    public static class BetaTestersBuildsGetToManyRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersBuildsGetToManyRelatedFieldsBuild value)
        {
            return value switch
            {
                BetaTestersBuildsGetToManyRelatedFieldsBuild.App => "app",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.BetaGroups => "betaGroups",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.BuildBundles => "buildBundles",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.BuildUpload => "buildUpload",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.ExpirationDate => "expirationDate",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.Expired => "expired",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.Icons => "icons",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.IndividualTesters => "individualTesters",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.ProcessingState => "processingState",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.UploadedDate => "uploadedDate",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaTestersBuildsGetToManyRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersBuildsGetToManyRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaTestersBuildsGetToManyRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => BetaTestersBuildsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaTestersBuildsGetToManyRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaTestersBuildsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaTestersBuildsGetToManyRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaTestersBuildsGetToManyRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaTestersBuildsGetToManyRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaTestersBuildsGetToManyRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaTestersBuildsGetToManyRelatedFieldsBuild.BuildBundles,
                "buildUpload" => BetaTestersBuildsGetToManyRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaTestersBuildsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaTestersBuildsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaTestersBuildsGetToManyRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaTestersBuildsGetToManyRelatedFieldsBuild.ExpirationDate,
                "expired" => BetaTestersBuildsGetToManyRelatedFieldsBuild.Expired,
                "iconAssetToken" => BetaTestersBuildsGetToManyRelatedFieldsBuild.IconAssetToken,
                "icons" => BetaTestersBuildsGetToManyRelatedFieldsBuild.Icons,
                "individualTesters" => BetaTestersBuildsGetToManyRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaTestersBuildsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaTestersBuildsGetToManyRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaTestersBuildsGetToManyRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaTestersBuildsGetToManyRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => BetaTestersBuildsGetToManyRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => BetaTestersBuildsGetToManyRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaTestersBuildsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaTestersBuildsGetToManyRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}