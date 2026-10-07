
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibrariesImagesGetToManyRelatedSortItem
    {
        /// <summary>
        ///
        /// </summary>
        MinuscreatedDate,
        /// <summary>
        ///
        /// </summary>
        MinuslastModifiedDate,
        /// <summary>
        ///
        /// </summary>
        MinusreferenceName,
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
        /// <summary>
        ///
        /// </summary>
        LastModifiedDate,
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibrariesImagesGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibrariesImagesGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppAssetLibrariesImagesGetToManyRelatedSortItem.MinuscreatedDate => "-createdDate",
                AppAssetLibrariesImagesGetToManyRelatedSortItem.MinuslastModifiedDate => "-lastModifiedDate",
                AppAssetLibrariesImagesGetToManyRelatedSortItem.MinusreferenceName => "-referenceName",
                AppAssetLibrariesImagesGetToManyRelatedSortItem.CreatedDate => "createdDate",
                AppAssetLibrariesImagesGetToManyRelatedSortItem.LastModifiedDate => "lastModifiedDate",
                AppAssetLibrariesImagesGetToManyRelatedSortItem.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibrariesImagesGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-createdDate" => AppAssetLibrariesImagesGetToManyRelatedSortItem.MinuscreatedDate,
                "-lastModifiedDate" => AppAssetLibrariesImagesGetToManyRelatedSortItem.MinuslastModifiedDate,
                "-referenceName" => AppAssetLibrariesImagesGetToManyRelatedSortItem.MinusreferenceName,
                "createdDate" => AppAssetLibrariesImagesGetToManyRelatedSortItem.CreatedDate,
                "lastModifiedDate" => AppAssetLibrariesImagesGetToManyRelatedSortItem.LastModifiedDate,
                "referenceName" => AppAssetLibrariesImagesGetToManyRelatedSortItem.ReferenceName,
                _ => null,
            };
        }
    }
}