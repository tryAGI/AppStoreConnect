
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionsGetInstanceIncludeItem
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
    public static class BackgroundAssetVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BackgroundAssetVersionsGetInstanceIncludeItem.AppStoreRelease => "appStoreRelease",
                BackgroundAssetVersionsGetInstanceIncludeItem.AssetFile => "assetFile",
                BackgroundAssetVersionsGetInstanceIncludeItem.BackgroundAsset => "backgroundAsset",
                BackgroundAssetVersionsGetInstanceIncludeItem.ExternalBetaRelease => "externalBetaRelease",
                BackgroundAssetVersionsGetInstanceIncludeItem.InternalBetaRelease => "internalBetaRelease",
                BackgroundAssetVersionsGetInstanceIncludeItem.ManifestFile => "manifestFile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreRelease" => BackgroundAssetVersionsGetInstanceIncludeItem.AppStoreRelease,
                "assetFile" => BackgroundAssetVersionsGetInstanceIncludeItem.AssetFile,
                "backgroundAsset" => BackgroundAssetVersionsGetInstanceIncludeItem.BackgroundAsset,
                "externalBetaRelease" => BackgroundAssetVersionsGetInstanceIncludeItem.ExternalBetaRelease,
                "internalBetaRelease" => BackgroundAssetVersionsGetInstanceIncludeItem.InternalBetaRelease,
                "manifestFile" => BackgroundAssetVersionsGetInstanceIncludeItem.ManifestFile,
                _ => null,
            };
        }
    }
}