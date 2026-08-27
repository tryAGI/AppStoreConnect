
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion
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
    public static class BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion value)
        {
            return value switch
            {
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.AppStoreRelease => "appStoreRelease",
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.AssetFile => "assetFile",
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.BackgroundAsset => "backgroundAsset",
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.CreatedDate => "createdDate",
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.ExternalBetaRelease => "externalBetaRelease",
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.InternalBetaRelease => "internalBetaRelease",
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.Locale => "locale",
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.ManifestFile => "manifestFile",
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.Platforms => "platforms",
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.State => "state",
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.StateDetails => "stateDetails",
                BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreRelease" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.AppStoreRelease,
                "assetFile" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.AssetFile,
                "backgroundAsset" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.BackgroundAsset,
                "backgroundAssetUploadFiles" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles,
                "createdDate" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.CreatedDate,
                "externalBetaRelease" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.ExternalBetaRelease,
                "internalBetaRelease" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.InternalBetaRelease,
                "locale" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.Locale,
                "manifestFile" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.ManifestFile,
                "platforms" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.Platforms,
                "state" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.State,
                "stateDetails" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.StateDetails,
                "version" => BackgroundAssetVersionExternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion.Version,
                _ => null,
            };
        }
    }
}