
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset
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
    public static class AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset value)
        {
            return value switch
            {
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.App => "app",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.AppStoreVersion => "appStoreVersion",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.Archived => "archived",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.AssetPackIdentifier => "assetPackIdentifier",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.CreatedDate => "createdDate",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.ExternalBetaVersion => "externalBetaVersion",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.InternalBetaVersion => "internalBetaVersion",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.UsedBytes => "usedBytes",
                AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.App,
                "appStoreVersion" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.AppStoreVersion,
                "archived" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.Archived,
                "assetPackIdentifier" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.AssetPackIdentifier,
                "createdDate" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.CreatedDate,
                "externalBetaVersion" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.ExternalBetaVersion,
                "internalBetaVersion" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.InternalBetaVersion,
                "usedBytes" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.UsedBytes,
                "versions" => AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset.Versions,
                _ => null,
            };
        }
    }
}