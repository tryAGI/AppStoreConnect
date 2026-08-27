
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset
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
    public static class BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset value)
        {
            return value switch
            {
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.App => "app",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.AppStoreVersion => "appStoreVersion",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.Archived => "archived",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.AssetPackIdentifier => "assetPackIdentifier",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.CreatedDate => "createdDate",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.ExternalBetaVersion => "externalBetaVersion",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.InternalBetaVersion => "internalBetaVersion",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.UsedBytes => "usedBytes",
                BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset? ToEnum(string value)
        {
            return value switch
            {
                "app" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.App,
                "appStoreVersion" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.AppStoreVersion,
                "archived" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.Archived,
                "assetPackIdentifier" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.AssetPackIdentifier,
                "createdDate" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.CreatedDate,
                "externalBetaVersion" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.ExternalBetaVersion,
                "internalBetaVersion" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.InternalBetaVersion,
                "usedBytes" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.UsedBytes,
                "versions" => BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset.Versions,
                _ => null,
            };
        }
    }
}