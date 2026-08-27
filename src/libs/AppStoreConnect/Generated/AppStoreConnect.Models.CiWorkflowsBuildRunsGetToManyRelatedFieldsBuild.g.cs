
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild
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
    public static class CiWorkflowsBuildRunsGetToManyRelatedFieldsBuildExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild value)
        {
            return value switch
            {
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.App => "app",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration => "appEncryptionDeclaration",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.AppStoreVersion => "appStoreVersion",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission => "betaAppReviewSubmission",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BetaBuildLocalizations => "betaBuildLocalizations",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BetaGroups => "betaGroups",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BuildAudienceType => "buildAudienceType",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BuildBetaDetail => "buildBetaDetail",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BuildBundles => "buildBundles",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BuildUpload => "buildUpload",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion => "computedMinMacOsVersion",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion => "computedMinVisionOsVersion",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.DiagnosticSignatures => "diagnosticSignatures",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.ExpirationDate => "expirationDate",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.Expired => "expired",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.IconAssetToken => "iconAssetToken",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.Icons => "icons",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.IndividualTesters => "individualTesters",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion => "lsMinimumSystemVersion",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.MinOsVersion => "minOsVersion",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.PerfPowerMetrics => "perfPowerMetrics",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.PreReleaseVersion => "preReleaseVersion",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.ProcessingState => "processingState",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.UploadedDate => "uploadedDate",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption => "usesNonExemptEncryption",
                CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.App,
                "appEncryptionDeclaration" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.AppEncryptionDeclaration,
                "appStoreVersion" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.AppStoreVersion,
                "betaAppReviewSubmission" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BetaAppReviewSubmission,
                "betaBuildLocalizations" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BetaBuildLocalizations,
                "betaGroups" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BetaGroups,
                "buildAudienceType" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BuildAudienceType,
                "buildBetaDetail" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BuildBetaDetail,
                "buildBundles" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BuildBundles,
                "buildUpload" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.BuildUpload,
                "computedMinMacOsVersion" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.ComputedMinMacOsVersion,
                "computedMinVisionOsVersion" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.ComputedMinVisionOsVersion,
                "diagnosticSignatures" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.DiagnosticSignatures,
                "expirationDate" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.ExpirationDate,
                "expired" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.Expired,
                "iconAssetToken" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.IconAssetToken,
                "icons" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.Icons,
                "individualTesters" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.IndividualTesters,
                "lsMinimumSystemVersion" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.LsMinimumSystemVersion,
                "minOsVersion" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.MinOsVersion,
                "perfPowerMetrics" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.PerfPowerMetrics,
                "preReleaseVersion" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.PreReleaseVersion,
                "processingState" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.ProcessingState,
                "uploadedDate" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.UploadedDate,
                "usesNonExemptEncryption" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.UsesNonExemptEncryption,
                "version" => CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild.Version,
                _ => null,
            };
        }
    }
}