
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEncryptionDeclarations,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersions,
        /// <summary>
        /// 
        /// </summary>
        Apps,
        /// <summary>
        /// 
        /// </summary>
        BetaAppReviewSubmissions,
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
        BetaTesters,
        /// <summary>
        /// 
        /// </summary>
        BuildBetaDetails,
        /// <summary>
        /// 
        /// </summary>
        BuildBundles,
        /// <summary>
        /// 
        /// </summary>
        BuildIcons,
        /// <summary>
        /// 
        /// </summary>
        BuildUploads,
        /// <summary>
        /// 
        /// </summary>
        PreReleaseVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BuildsResponseIncludedItemDiscriminatorType.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BuildsResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                BuildsResponseIncludedItemDiscriminatorType.Apps => "apps",
                BuildsResponseIncludedItemDiscriminatorType.BetaAppReviewSubmissions => "betaAppReviewSubmissions",
                BuildsResponseIncludedItemDiscriminatorType.BetaBuildLocalizations => "betaBuildLocalizations",
                BuildsResponseIncludedItemDiscriminatorType.BetaGroups => "betaGroups",
                BuildsResponseIncludedItemDiscriminatorType.BetaTesters => "betaTesters",
                BuildsResponseIncludedItemDiscriminatorType.BuildBetaDetails => "buildBetaDetails",
                BuildsResponseIncludedItemDiscriminatorType.BuildBundles => "buildBundles",
                BuildsResponseIncludedItemDiscriminatorType.BuildIcons => "buildIcons",
                BuildsResponseIncludedItemDiscriminatorType.BuildUploads => "buildUploads",
                BuildsResponseIncludedItemDiscriminatorType.PreReleaseVersions => "preReleaseVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarations" => BuildsResponseIncludedItemDiscriminatorType.AppEncryptionDeclarations,
                "appStoreVersions" => BuildsResponseIncludedItemDiscriminatorType.AppStoreVersions,
                "apps" => BuildsResponseIncludedItemDiscriminatorType.Apps,
                "betaAppReviewSubmissions" => BuildsResponseIncludedItemDiscriminatorType.BetaAppReviewSubmissions,
                "betaBuildLocalizations" => BuildsResponseIncludedItemDiscriminatorType.BetaBuildLocalizations,
                "betaGroups" => BuildsResponseIncludedItemDiscriminatorType.BetaGroups,
                "betaTesters" => BuildsResponseIncludedItemDiscriminatorType.BetaTesters,
                "buildBetaDetails" => BuildsResponseIncludedItemDiscriminatorType.BuildBetaDetails,
                "buildBundles" => BuildsResponseIncludedItemDiscriminatorType.BuildBundles,
                "buildIcons" => BuildsResponseIncludedItemDiscriminatorType.BuildIcons,
                "buildUploads" => BuildsResponseIncludedItemDiscriminatorType.BuildUploads,
                "preReleaseVersions" => BuildsResponseIncludedItemDiscriminatorType.PreReleaseVersions,
                _ => null,
            };
        }
    }
}