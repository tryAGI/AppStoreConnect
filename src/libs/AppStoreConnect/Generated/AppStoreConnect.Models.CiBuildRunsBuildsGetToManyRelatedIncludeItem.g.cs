
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedIncludeItem
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
    public static class CiBuildRunsBuildsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedIncludeItem.App => "app",
                CiBuildRunsBuildsGetToManyRelatedIncludeItem.AppEncryptionDeclaration => "appEncryptionDeclaration",
                CiBuildRunsBuildsGetToManyRelatedIncludeItem.AppStoreVersion => "appStoreVersion",
                CiBuildRunsBuildsGetToManyRelatedIncludeItem.BetaAppReviewSubmission => "betaAppReviewSubmission",
                CiBuildRunsBuildsGetToManyRelatedIncludeItem.BetaBuildLocalizations => "betaBuildLocalizations",
                CiBuildRunsBuildsGetToManyRelatedIncludeItem.BetaGroups => "betaGroups",
                CiBuildRunsBuildsGetToManyRelatedIncludeItem.BuildBetaDetail => "buildBetaDetail",
                CiBuildRunsBuildsGetToManyRelatedIncludeItem.BuildBundles => "buildBundles",
                CiBuildRunsBuildsGetToManyRelatedIncludeItem.BuildUpload => "buildUpload",
                CiBuildRunsBuildsGetToManyRelatedIncludeItem.Icons => "icons",
                CiBuildRunsBuildsGetToManyRelatedIncludeItem.IndividualTesters => "individualTesters",
                CiBuildRunsBuildsGetToManyRelatedIncludeItem.PreReleaseVersion => "preReleaseVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiBuildRunsBuildsGetToManyRelatedIncludeItem.App,
                "appEncryptionDeclaration" => CiBuildRunsBuildsGetToManyRelatedIncludeItem.AppEncryptionDeclaration,
                "appStoreVersion" => CiBuildRunsBuildsGetToManyRelatedIncludeItem.AppStoreVersion,
                "betaAppReviewSubmission" => CiBuildRunsBuildsGetToManyRelatedIncludeItem.BetaAppReviewSubmission,
                "betaBuildLocalizations" => CiBuildRunsBuildsGetToManyRelatedIncludeItem.BetaBuildLocalizations,
                "betaGroups" => CiBuildRunsBuildsGetToManyRelatedIncludeItem.BetaGroups,
                "buildBetaDetail" => CiBuildRunsBuildsGetToManyRelatedIncludeItem.BuildBetaDetail,
                "buildBundles" => CiBuildRunsBuildsGetToManyRelatedIncludeItem.BuildBundles,
                "buildUpload" => CiBuildRunsBuildsGetToManyRelatedIncludeItem.BuildUpload,
                "icons" => CiBuildRunsBuildsGetToManyRelatedIncludeItem.Icons,
                "individualTesters" => CiBuildRunsBuildsGetToManyRelatedIncludeItem.IndividualTesters,
                "preReleaseVersion" => CiBuildRunsBuildsGetToManyRelatedIncludeItem.PreReleaseVersion,
                _ => null,
            };
        }
    }
}