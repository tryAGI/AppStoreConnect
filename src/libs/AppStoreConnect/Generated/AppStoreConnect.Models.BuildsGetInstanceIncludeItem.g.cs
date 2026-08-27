
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetInstanceIncludeItem
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
    public static class BuildsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BuildsGetInstanceIncludeItem.App => "app",
                BuildsGetInstanceIncludeItem.AppEncryptionDeclaration => "appEncryptionDeclaration",
                BuildsGetInstanceIncludeItem.AppStoreVersion => "appStoreVersion",
                BuildsGetInstanceIncludeItem.BetaAppReviewSubmission => "betaAppReviewSubmission",
                BuildsGetInstanceIncludeItem.BetaBuildLocalizations => "betaBuildLocalizations",
                BuildsGetInstanceIncludeItem.BetaGroups => "betaGroups",
                BuildsGetInstanceIncludeItem.BuildBetaDetail => "buildBetaDetail",
                BuildsGetInstanceIncludeItem.BuildBundles => "buildBundles",
                BuildsGetInstanceIncludeItem.BuildUpload => "buildUpload",
                BuildsGetInstanceIncludeItem.Icons => "icons",
                BuildsGetInstanceIncludeItem.IndividualTesters => "individualTesters",
                BuildsGetInstanceIncludeItem.PreReleaseVersion => "preReleaseVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsGetInstanceIncludeItem.App,
                "appEncryptionDeclaration" => BuildsGetInstanceIncludeItem.AppEncryptionDeclaration,
                "appStoreVersion" => BuildsGetInstanceIncludeItem.AppStoreVersion,
                "betaAppReviewSubmission" => BuildsGetInstanceIncludeItem.BetaAppReviewSubmission,
                "betaBuildLocalizations" => BuildsGetInstanceIncludeItem.BetaBuildLocalizations,
                "betaGroups" => BuildsGetInstanceIncludeItem.BetaGroups,
                "buildBetaDetail" => BuildsGetInstanceIncludeItem.BuildBetaDetail,
                "buildBundles" => BuildsGetInstanceIncludeItem.BuildBundles,
                "buildUpload" => BuildsGetInstanceIncludeItem.BuildUpload,
                "icons" => BuildsGetInstanceIncludeItem.Icons,
                "individualTesters" => BuildsGetInstanceIncludeItem.IndividualTesters,
                "preReleaseVersion" => BuildsGetInstanceIncludeItem.PreReleaseVersion,
                _ => null,
            };
        }
    }
}