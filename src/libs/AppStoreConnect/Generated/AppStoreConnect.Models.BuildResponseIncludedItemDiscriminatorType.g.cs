
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildResponseIncludedItemDiscriminatorType
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
    public static class BuildResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BuildResponseIncludedItemDiscriminatorType.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BuildResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                BuildResponseIncludedItemDiscriminatorType.Apps => "apps",
                BuildResponseIncludedItemDiscriminatorType.BetaAppReviewSubmissions => "betaAppReviewSubmissions",
                BuildResponseIncludedItemDiscriminatorType.BetaBuildLocalizations => "betaBuildLocalizations",
                BuildResponseIncludedItemDiscriminatorType.BetaGroups => "betaGroups",
                BuildResponseIncludedItemDiscriminatorType.BetaTesters => "betaTesters",
                BuildResponseIncludedItemDiscriminatorType.BuildBetaDetails => "buildBetaDetails",
                BuildResponseIncludedItemDiscriminatorType.BuildBundles => "buildBundles",
                BuildResponseIncludedItemDiscriminatorType.BuildIcons => "buildIcons",
                BuildResponseIncludedItemDiscriminatorType.BuildUploads => "buildUploads",
                BuildResponseIncludedItemDiscriminatorType.PreReleaseVersions => "preReleaseVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appEncryptionDeclarations" => BuildResponseIncludedItemDiscriminatorType.AppEncryptionDeclarations,
                "appStoreVersions" => BuildResponseIncludedItemDiscriminatorType.AppStoreVersions,
                "apps" => BuildResponseIncludedItemDiscriminatorType.Apps,
                "betaAppReviewSubmissions" => BuildResponseIncludedItemDiscriminatorType.BetaAppReviewSubmissions,
                "betaBuildLocalizations" => BuildResponseIncludedItemDiscriminatorType.BetaBuildLocalizations,
                "betaGroups" => BuildResponseIncludedItemDiscriminatorType.BetaGroups,
                "betaTesters" => BuildResponseIncludedItemDiscriminatorType.BetaTesters,
                "buildBetaDetails" => BuildResponseIncludedItemDiscriminatorType.BuildBetaDetails,
                "buildBundles" => BuildResponseIncludedItemDiscriminatorType.BuildBundles,
                "buildIcons" => BuildResponseIncludedItemDiscriminatorType.BuildIcons,
                "buildUploads" => BuildResponseIncludedItemDiscriminatorType.BuildUploads,
                "preReleaseVersions" => BuildResponseIncludedItemDiscriminatorType.PreReleaseVersions,
                _ => null,
            };
        }
    }
}