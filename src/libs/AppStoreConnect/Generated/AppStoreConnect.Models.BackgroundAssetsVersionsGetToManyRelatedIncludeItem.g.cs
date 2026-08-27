
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetsVersionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreRelease,
        /// <summary>
        ///
        /// </summary>
        AssetFile,
        /// <summary>
        ///
        /// </summary>
        BackgroundAsset,
        /// <summary>
        ///
        /// </summary>
        ExternalBetaRelease,
        /// <summary>
        ///
        /// </summary>
        InternalBetaRelease,
        /// <summary>
        ///
        /// </summary>
        ManifestFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetsVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                BackgroundAssetsVersionsGetToManyRelatedIncludeItem.AppStoreRelease => "appStoreRelease",
                BackgroundAssetsVersionsGetToManyRelatedIncludeItem.AssetFile => "assetFile",
                BackgroundAssetsVersionsGetToManyRelatedIncludeItem.BackgroundAsset => "backgroundAsset",
                BackgroundAssetsVersionsGetToManyRelatedIncludeItem.ExternalBetaRelease => "externalBetaRelease",
                BackgroundAssetsVersionsGetToManyRelatedIncludeItem.InternalBetaRelease => "internalBetaRelease",
                BackgroundAssetsVersionsGetToManyRelatedIncludeItem.ManifestFile => "manifestFile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreRelease" => BackgroundAssetsVersionsGetToManyRelatedIncludeItem.AppStoreRelease,
                "assetFile" => BackgroundAssetsVersionsGetToManyRelatedIncludeItem.AssetFile,
                "backgroundAsset" => BackgroundAssetsVersionsGetToManyRelatedIncludeItem.BackgroundAsset,
                "externalBetaRelease" => BackgroundAssetsVersionsGetToManyRelatedIncludeItem.ExternalBetaRelease,
                "internalBetaRelease" => BackgroundAssetsVersionsGetToManyRelatedIncludeItem.InternalBetaRelease,
                "manifestFile" => BackgroundAssetsVersionsGetToManyRelatedIncludeItem.ManifestFile,
                _ => null,
            };
        }
    }
}