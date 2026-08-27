
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion
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
        BackgroundAssetUploadFiles,
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
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
        Locale,
        /// <summary>
        ///
        /// </summary>
        ManifestFile,
        /// <summary>
        ///
        /// </summary>
        Platforms,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        StateDetails,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetsGetInstanceFieldsBackgroundAssetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion value)
        {
            return value switch
            {
                BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.AppStoreRelease => "appStoreRelease",
                BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.AssetFile => "assetFile",
                BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.BackgroundAsset => "backgroundAsset",
                BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.CreatedDate => "createdDate",
                BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.ExternalBetaRelease => "externalBetaRelease",
                BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.InternalBetaRelease => "internalBetaRelease",
                BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.Locale => "locale",
                BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.ManifestFile => "manifestFile",
                BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.Platforms => "platforms",
                BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.State => "state",
                BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.StateDetails => "stateDetails",
                BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreRelease" => BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.AppStoreRelease,
                "assetFile" => BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.AssetFile,
                "backgroundAsset" => BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.BackgroundAsset,
                "backgroundAssetUploadFiles" => BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles,
                "createdDate" => BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.CreatedDate,
                "externalBetaRelease" => BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.ExternalBetaRelease,
                "internalBetaRelease" => BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.InternalBetaRelease,
                "locale" => BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.Locale,
                "manifestFile" => BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.ManifestFile,
                "platforms" => BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.Platforms,
                "state" => BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.State,
                "stateDetails" => BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.StateDetails,
                "version" => BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion.Version,
                _ => null,
            };
        }
    }
}