
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedIncludeItem
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
        Icons,
        /// <summary>
        /// 
        /// </summary>
        IndividualTesters,
        /// <summary>
        /// 
        /// </summary>
        PreReleaseVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBetaDetailsBuildGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedIncludeItem.App => "app",
                BuildBetaDetailsBuildGetToOneRelatedIncludeItem.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BuildBetaDetailsBuildGetToOneRelatedIncludeItem.AppStoreVersion => "appStoreVersion",
                BuildBetaDetailsBuildGetToOneRelatedIncludeItem.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BuildBetaDetailsBuildGetToOneRelatedIncludeItem.BetaBuildLocalizations => "betaBuildLocalizations",
                BuildBetaDetailsBuildGetToOneRelatedIncludeItem.BetaGroups => "betaGroups",
                BuildBetaDetailsBuildGetToOneRelatedIncludeItem.BuildBetaDetail => "buildBetaDetail",
                BuildBetaDetailsBuildGetToOneRelatedIncludeItem.BuildBundles => "buildBundles",
                BuildBetaDetailsBuildGetToOneRelatedIncludeItem.BuildUpload => "buildUpload",
                BuildBetaDetailsBuildGetToOneRelatedIncludeItem.Icons => "icons",
                BuildBetaDetailsBuildGetToOneRelatedIncludeItem.IndividualTesters => "individualTesters",
                BuildBetaDetailsBuildGetToOneRelatedIncludeItem.PreReleaseVersion => "preReleaseVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildBetaDetailsBuildGetToOneRelatedIncludeItem.App,
                "appEncryptionDeclaration" => BuildBetaDetailsBuildGetToOneRelatedIncludeItem.AppEncryptionDeclaration,
                "appStoreVersion" => BuildBetaDetailsBuildGetToOneRelatedIncludeItem.AppStoreVersion,
                "betaAppReviewSubmission" => BuildBetaDetailsBuildGetToOneRelatedIncludeItem.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BuildBetaDetailsBuildGetToOneRelatedIncludeItem.BetaBuildLocalizations,
                "betaGroups" => BuildBetaDetailsBuildGetToOneRelatedIncludeItem.BetaGroups,
                "buildBetaDetail" => BuildBetaDetailsBuildGetToOneRelatedIncludeItem.BuildBetaDetail,
                "buildBundles" => BuildBetaDetailsBuildGetToOneRelatedIncludeItem.BuildBundles,
                "buildUpload" => BuildBetaDetailsBuildGetToOneRelatedIncludeItem.BuildUpload,
                "icons" => BuildBetaDetailsBuildGetToOneRelatedIncludeItem.Icons,
                "individualTesters" => BuildBetaDetailsBuildGetToOneRelatedIncludeItem.IndividualTesters,
                "preReleaseVersion" => BuildBetaDetailsBuildGetToOneRelatedIncludeItem.PreReleaseVersion,
                _ => null,
            };
        }
    }
}