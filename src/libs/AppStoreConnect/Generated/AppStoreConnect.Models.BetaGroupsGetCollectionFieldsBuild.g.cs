
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupsGetCollectionFieldsBuild
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
    public static class BetaGroupsGetCollectionFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsGetCollectionFieldsBuild value)
        {
            return value switch
            {
                BetaGroupsGetCollectionFieldsBuild.App => "app",
                BetaGroupsGetCollectionFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaGroupsGetCollectionFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaGroupsGetCollectionFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaGroupsGetCollectionFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaGroupsGetCollectionFieldsBuild.BetaGroups => "betaGroups",
                BetaGroupsGetCollectionFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaGroupsGetCollectionFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaGroupsGetCollectionFieldsBuild.BuildBundles => "buildBundles",
                BetaGroupsGetCollectionFieldsBuild.BuildUpload => "buildUpload",
                BetaGroupsGetCollectionFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaGroupsGetCollectionFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaGroupsGetCollectionFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaGroupsGetCollectionFieldsBuild.ExpirationDate => "expirationDate",
                BetaGroupsGetCollectionFieldsBuild.Expired => "expired",
                BetaGroupsGetCollectionFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaGroupsGetCollectionFieldsBuild.Icons => "icons",
                BetaGroupsGetCollectionFieldsBuild.IndividualTesters => "individualTesters",
                BetaGroupsGetCollectionFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaGroupsGetCollectionFieldsBuild.MinOsVersion => "minOsVersion",
                BetaGroupsGetCollectionFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaGroupsGetCollectionFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaGroupsGetCollectionFieldsBuild.ProcessingState => "processingState",
                BetaGroupsGetCollectionFieldsBuild.UploadedDate => "uploadedDate",
                BetaGroupsGetCollectionFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaGroupsGetCollectionFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsGetCollectionFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaGroupsGetCollectionFieldsBuild.App,
                "appEncryptionDeclaration" => BetaGroupsGetCollectionFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaGroupsGetCollectionFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaGroupsGetCollectionFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaGroupsGetCollectionFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaGroupsGetCollectionFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaGroupsGetCollectionFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaGroupsGetCollectionFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaGroupsGetCollectionFieldsBuild.BuildBundles,
                "buildUpload" => BetaGroupsGetCollectionFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaGroupsGetCollectionFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaGroupsGetCollectionFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaGroupsGetCollectionFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaGroupsGetCollectionFieldsBuild.ExpirationDate,
                "expired" => BetaGroupsGetCollectionFieldsBuild.Expired,
                "iconAssetToken" => BetaGroupsGetCollectionFieldsBuild.IconAssetToken,
                "icons" => BetaGroupsGetCollectionFieldsBuild.Icons,
                "individualTesters" => BetaGroupsGetCollectionFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaGroupsGetCollectionFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaGroupsGetCollectionFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaGroupsGetCollectionFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaGroupsGetCollectionFieldsBuild.PreReleaseVersion,
                "processingState" => BetaGroupsGetCollectionFieldsBuild.ProcessingState,
                "uploadedDate" => BetaGroupsGetCollectionFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaGroupsGetCollectionFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaGroupsGetCollectionFieldsBuild.Version,
                _ => null,
            };
        }
    }
}