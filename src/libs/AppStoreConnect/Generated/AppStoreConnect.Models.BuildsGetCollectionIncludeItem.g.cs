
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetCollectionIncludeItem
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
    public static class BuildsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionIncludeItem value)
        {
            return value switch
            {
                BuildsGetCollectionIncludeItem.App => "app",
                BuildsGetCollectionIncludeItem.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BuildsGetCollectionIncludeItem.AppStoreVersion => "appStoreVersion",
                BuildsGetCollectionIncludeItem.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BuildsGetCollectionIncludeItem.BetaBuildLocalizations => "betaBuildLocalizations",
                BuildsGetCollectionIncludeItem.BetaGroups => "betaGroups",
                BuildsGetCollectionIncludeItem.BuildBetaDetail => "buildBetaDetail",
                BuildsGetCollectionIncludeItem.BuildBundles => "buildBundles",
                BuildsGetCollectionIncludeItem.BuildUpload => "buildUpload",
                BuildsGetCollectionIncludeItem.Icons => "icons",
                BuildsGetCollectionIncludeItem.IndividualTesters => "individualTesters",
                BuildsGetCollectionIncludeItem.PreReleaseVersion => "preReleaseVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsGetCollectionIncludeItem.App,
                "appEncryptionDeclaration" => BuildsGetCollectionIncludeItem.AppEncryptionDeclaration,
                "appStoreVersion" => BuildsGetCollectionIncludeItem.AppStoreVersion,
                "betaAppReviewSubmission" => BuildsGetCollectionIncludeItem.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BuildsGetCollectionIncludeItem.BetaBuildLocalizations,
                "betaGroups" => BuildsGetCollectionIncludeItem.BetaGroups,
                "buildBetaDetail" => BuildsGetCollectionIncludeItem.BuildBetaDetail,
                "buildBundles" => BuildsGetCollectionIncludeItem.BuildBundles,
                "buildUpload" => BuildsGetCollectionIncludeItem.BuildUpload,
                "icons" => BuildsGetCollectionIncludeItem.Icons,
                "individualTesters" => BuildsGetCollectionIncludeItem.IndividualTesters,
                "preReleaseVersion" => BuildsGetCollectionIncludeItem.PreReleaseVersion,
                _ => null,
            };
        }
    }
}