
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion
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
    public static class BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion value)
        {
            return value switch
            {
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.AppStoreRelease => "appStoreRelease",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.AssetFile => "assetFile",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.BackgroundAsset => "backgroundAsset",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.CreatedDate => "createdDate",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.ExternalBetaRelease => "externalBetaRelease",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.InternalBetaRelease => "internalBetaRelease",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.Locale => "locale",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.ManifestFile => "manifestFile",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.Platforms => "platforms",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.State => "state",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.StateDetails => "stateDetails",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreRelease" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.AppStoreRelease,
                "assetFile" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.AssetFile,
                "backgroundAsset" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.BackgroundAsset,
                "backgroundAssetUploadFiles" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles,
                "createdDate" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.CreatedDate,
                "externalBetaRelease" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.ExternalBetaRelease,
                "internalBetaRelease" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.InternalBetaRelease,
                "locale" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.Locale,
                "manifestFile" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.ManifestFile,
                "platforms" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.Platforms,
                "state" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.State,
                "stateDetails" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.StateDetails,
                "version" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion.Version,
                _ => null,
            };
        }
    }
}