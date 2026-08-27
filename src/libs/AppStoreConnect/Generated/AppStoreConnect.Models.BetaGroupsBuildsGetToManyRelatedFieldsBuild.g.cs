
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupsBuildsGetToManyRelatedFieldsBuild
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
    public static class BetaGroupsBuildsGetToManyRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsBuildsGetToManyRelatedFieldsBuild value)
        {
            return value switch
            {
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.App => "app",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.BetaGroups => "betaGroups",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.BuildBundles => "buildBundles",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.BuildUpload => "buildUpload",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.ExpirationDate => "expirationDate",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.Expired => "expired",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.Icons => "icons",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.IndividualTesters => "individualTesters",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.ProcessingState => "processingState",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.UploadedDate => "uploadedDate",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                BetaGroupsBuildsGetToManyRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsBuildsGetToManyRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.BuildBundles,
                "buildUpload" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.ExpirationDate,
                "expired" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.Expired,
                "iconAssetToken" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.IconAssetToken,
                "icons" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.Icons,
                "individualTesters" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => BetaGroupsBuildsGetToManyRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}