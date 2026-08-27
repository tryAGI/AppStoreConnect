
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersion,
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        AssetPackIdentifier,
        /// <summary>
        /// 
        /// </summary>
        CreatedDate,
        /// <summary>
        /// 
        /// </summary>
        ExternalBetaVersion,
        /// <summary>
        /// 
        /// </summary>
        InternalBetaVersion,
        /// <summary>
        /// 
        /// </summary>
        UsedBytes,
        /// <summary>
        /// 
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset value)
        {
            return value switch
            {
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.App => "app",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.AppStoreVersion => "appStoreVersion",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.Archived => "archived",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.AssetPackIdentifier => "assetPackIdentifier",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.CreatedDate => "createdDate",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.ExternalBetaVersion => "externalBetaVersion",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.InternalBetaVersion => "internalBetaVersion",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.UsedBytes => "usedBytes",
                BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset? ToEnum(string value)
        {
            return value switch
            {
                "app" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.App,
                "appStoreVersion" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.AppStoreVersion,
                "archived" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.Archived,
                "assetPackIdentifier" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.AssetPackIdentifier,
                "createdDate" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.CreatedDate,
                "externalBetaVersion" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.ExternalBetaVersion,
                "internalBetaVersion" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.InternalBetaVersion,
                "usedBytes" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.UsedBytes,
                "versions" => BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset.Versions,
                _ => null,
            };
        }
    }
}