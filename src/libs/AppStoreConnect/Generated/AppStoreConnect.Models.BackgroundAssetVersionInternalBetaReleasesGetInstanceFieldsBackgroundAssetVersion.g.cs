
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion
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
    public static class BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion value)
        {
            return value switch
            {
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.AppStoreRelease => "appStoreRelease",
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.AssetFile => "assetFile",
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.BackgroundAsset => "backgroundAsset",
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.CreatedDate => "createdDate",
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.ExternalBetaRelease => "externalBetaRelease",
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.InternalBetaRelease => "internalBetaRelease",
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.Locale => "locale",
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.ManifestFile => "manifestFile",
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.Platforms => "platforms",
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.State => "state",
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.StateDetails => "stateDetails",
                BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreRelease" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.AppStoreRelease,
                "assetFile" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.AssetFile,
                "backgroundAsset" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.BackgroundAsset,
                "backgroundAssetUploadFiles" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles,
                "createdDate" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.CreatedDate,
                "externalBetaRelease" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.ExternalBetaRelease,
                "internalBetaRelease" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.InternalBetaRelease,
                "locale" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.Locale,
                "manifestFile" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.ManifestFile,
                "platforms" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.Platforms,
                "state" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.State,
                "stateDetails" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.StateDetails,
                "version" => BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.Version,
                _ => null,
            };
        }
    }
}