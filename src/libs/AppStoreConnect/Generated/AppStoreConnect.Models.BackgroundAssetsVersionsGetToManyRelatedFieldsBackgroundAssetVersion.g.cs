
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion
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
    public static class BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion value)
        {
            return value switch
            {
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.AppStoreRelease => "appStoreRelease",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.AssetFile => "assetFile",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.BackgroundAsset => "backgroundAsset",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.CreatedDate => "createdDate",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.ExternalBetaRelease => "externalBetaRelease",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.InternalBetaRelease => "internalBetaRelease",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.Locale => "locale",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.ManifestFile => "manifestFile",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.Platforms => "platforms",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.State => "state",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.StateDetails => "stateDetails",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreRelease" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.AppStoreRelease,
                "assetFile" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.AssetFile,
                "backgroundAsset" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.BackgroundAsset,
                "backgroundAssetUploadFiles" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles,
                "createdDate" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.CreatedDate,
                "externalBetaRelease" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.ExternalBetaRelease,
                "internalBetaRelease" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.InternalBetaRelease,
                "locale" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.Locale,
                "manifestFile" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.ManifestFile,
                "platforms" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.Platforms,
                "state" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.State,
                "stateDetails" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.StateDetails,
                "version" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion.Version,
                _ => null,
            };
        }
    }
}