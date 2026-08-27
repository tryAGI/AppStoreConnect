
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild
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
    public static class GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild value)
        {
            return value switch
            {
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.App => "app",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BetaGroups => "betaGroups",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BuildBundles => "buildBundles",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BuildUpload => "buildUpload",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.ExpirationDate => "expirationDate",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.Expired => "expired",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.Icons => "icons",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.IndividualTesters => "individualTesters",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.ProcessingState => "processingState",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.UploadedDate => "uploadedDate",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BuildBundles,
                "buildUpload" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.ExpirationDate,
                "expired" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.Expired,
                "iconAssetToken" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.IconAssetToken,
                "icons" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.Icons,
                "individualTesters" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}