
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion
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
    public static class BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion value)
        {
            return value switch
            {
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.AppStoreRelease => "appStoreRelease",
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.AssetFile => "assetFile",
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.BackgroundAsset => "backgroundAsset",
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.CreatedDate => "createdDate",
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.ExternalBetaRelease => "externalBetaRelease",
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.InternalBetaRelease => "internalBetaRelease",
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.Locale => "locale",
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.ManifestFile => "manifestFile",
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.Platforms => "platforms",
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.State => "state",
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.StateDetails => "stateDetails",
                BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreRelease" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.AppStoreRelease,
                "assetFile" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.AssetFile,
                "backgroundAsset" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.BackgroundAsset,
                "backgroundAssetUploadFiles" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles,
                "createdDate" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.CreatedDate,
                "externalBetaRelease" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.ExternalBetaRelease,
                "internalBetaRelease" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.InternalBetaRelease,
                "locale" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.Locale,
                "manifestFile" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.ManifestFile,
                "platforms" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.Platforms,
                "state" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.State,
                "stateDetails" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.StateDetails,
                "version" => BackgroundAssetVersionAppStoreReleasesGetInstanceFieldsBackgroundAssetVersion.Version,
                _ => null,
            };
        }
    }
}