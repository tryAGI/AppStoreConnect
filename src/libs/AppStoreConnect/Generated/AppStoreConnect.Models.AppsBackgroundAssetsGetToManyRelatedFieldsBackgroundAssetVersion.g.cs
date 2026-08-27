
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion
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
    public static class AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion value)
        {
            return value switch
            {
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.AppStoreRelease => "appStoreRelease",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.AssetFile => "assetFile",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.BackgroundAsset => "backgroundAsset",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.CreatedDate => "createdDate",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.ExternalBetaRelease => "externalBetaRelease",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.InternalBetaRelease => "internalBetaRelease",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.Locale => "locale",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.ManifestFile => "manifestFile",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.Platforms => "platforms",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.State => "state",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.StateDetails => "stateDetails",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreRelease" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.AppStoreRelease,
                "assetFile" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.AssetFile,
                "backgroundAsset" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.BackgroundAsset,
                "backgroundAssetUploadFiles" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles,
                "createdDate" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.CreatedDate,
                "externalBetaRelease" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.ExternalBetaRelease,
                "internalBetaRelease" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.InternalBetaRelease,
                "locale" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.Locale,
                "manifestFile" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.ManifestFile,
                "platforms" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.Platforms,
                "state" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.State,
                "stateDetails" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.StateDetails,
                "version" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion.Version,
                _ => null,
            };
        }
    }
}