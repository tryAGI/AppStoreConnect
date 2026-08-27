
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBackgroundAssetsGetToManyRelatedSortItem
    {
        /// <summary>
        /// 
        /// </summary>
        MinusassetPackIdentifier,
        /// <summary>
        /// 
        /// </summary>
        MinuscreatedDate,
        /// <summary>
        /// 
        /// </summary>
        AssetPackIdentifier,
        /// <summary>
        /// 
        /// </summary>
        CreatedDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsBackgroundAssetsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBackgroundAssetsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppsBackgroundAssetsGetToManyRelatedSortItem.MinusassetPackIdentifier => "-assetPackIdentifier",
                AppsBackgroundAssetsGetToManyRelatedSortItem.MinuscreatedDate => "-createdDate",
                AppsBackgroundAssetsGetToManyRelatedSortItem.AssetPackIdentifier => "assetPackIdentifier",
                AppsBackgroundAssetsGetToManyRelatedSortItem.CreatedDate => "createdDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBackgroundAssetsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-assetPackIdentifier" => AppsBackgroundAssetsGetToManyRelatedSortItem.MinusassetPackIdentifier,
                "-createdDate" => AppsBackgroundAssetsGetToManyRelatedSortItem.MinuscreatedDate,
                "assetPackIdentifier" => AppsBackgroundAssetsGetToManyRelatedSortItem.AssetPackIdentifier,
                "createdDate" => AppsBackgroundAssetsGetToManyRelatedSortItem.CreatedDate,
                _ => null,
            };
        }
    }
}