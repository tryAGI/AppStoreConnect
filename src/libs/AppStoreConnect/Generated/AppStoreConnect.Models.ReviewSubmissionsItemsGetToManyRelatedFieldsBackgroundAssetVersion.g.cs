
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion
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
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.AppStoreRelease => "appStoreRelease",
                ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.AssetFile => "assetFile",
                ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.BackgroundAsset => "backgroundAsset",
                ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.CreatedDate => "createdDate",
                ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.ExternalBetaRelease => "externalBetaRelease",
                ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.InternalBetaRelease => "internalBetaRelease",
                ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.Locale => "locale",
                ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.ManifestFile => "manifestFile",
                ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.Platforms => "platforms",
                ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.StateDetails => "stateDetails",
                ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion? ToEnum(string value)
        {
            return value switch
            {
                "appStoreRelease" => ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.AppStoreRelease,
                "assetFile" => ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.AssetFile,
                "backgroundAsset" => ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.BackgroundAsset,
                "backgroundAssetUploadFiles" => ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.BackgroundAssetUploadFiles,
                "createdDate" => ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.CreatedDate,
                "externalBetaRelease" => ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.ExternalBetaRelease,
                "internalBetaRelease" => ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.InternalBetaRelease,
                "locale" => ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.Locale,
                "manifestFile" => ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.ManifestFile,
                "platforms" => ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.Platforms,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.State,
                "stateDetails" => ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.StateDetails,
                "version" => ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion.Version,
                _ => null,
            };
        }
    }
}