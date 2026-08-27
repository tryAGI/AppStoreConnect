
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetsGetInstanceFieldsBackgroundAsset
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
    public static class BackgroundAssetsGetInstanceFieldsBackgroundAssetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsGetInstanceFieldsBackgroundAsset value)
        {
            return value switch
            {
                BackgroundAssetsGetInstanceFieldsBackgroundAsset.App => "app",
                BackgroundAssetsGetInstanceFieldsBackgroundAsset.AppStoreVersion => "appStoreVersion",
                BackgroundAssetsGetInstanceFieldsBackgroundAsset.Archived => "archived",
                BackgroundAssetsGetInstanceFieldsBackgroundAsset.AssetPackIdentifier => "assetPackIdentifier",
                BackgroundAssetsGetInstanceFieldsBackgroundAsset.CreatedDate => "createdDate",
                BackgroundAssetsGetInstanceFieldsBackgroundAsset.ExternalBetaVersion => "externalBetaVersion",
                BackgroundAssetsGetInstanceFieldsBackgroundAsset.InternalBetaVersion => "internalBetaVersion",
                BackgroundAssetsGetInstanceFieldsBackgroundAsset.UsedBytes => "usedBytes",
                BackgroundAssetsGetInstanceFieldsBackgroundAsset.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsGetInstanceFieldsBackgroundAsset? ToEnum(string value)
        {
            return value switch
            {
                "app" => BackgroundAssetsGetInstanceFieldsBackgroundAsset.App,
                "appStoreVersion" => BackgroundAssetsGetInstanceFieldsBackgroundAsset.AppStoreVersion,
                "archived" => BackgroundAssetsGetInstanceFieldsBackgroundAsset.Archived,
                "assetPackIdentifier" => BackgroundAssetsGetInstanceFieldsBackgroundAsset.AssetPackIdentifier,
                "createdDate" => BackgroundAssetsGetInstanceFieldsBackgroundAsset.CreatedDate,
                "externalBetaVersion" => BackgroundAssetsGetInstanceFieldsBackgroundAsset.ExternalBetaVersion,
                "internalBetaVersion" => BackgroundAssetsGetInstanceFieldsBackgroundAsset.InternalBetaVersion,
                "usedBytes" => BackgroundAssetsGetInstanceFieldsBackgroundAsset.UsedBytes,
                "versions" => BackgroundAssetsGetInstanceFieldsBackgroundAsset.Versions,
                _ => null,
            };
        }
    }
}