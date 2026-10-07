
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibrariesVideosGetToManyRelatedSortItem
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
    public static class AppAssetLibrariesVideosGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibrariesVideosGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppAssetLibrariesVideosGetToManyRelatedSortItem.MinuscreatedDate => "-createdDate",
                AppAssetLibrariesVideosGetToManyRelatedSortItem.MinuslastModifiedDate => "-lastModifiedDate",
                AppAssetLibrariesVideosGetToManyRelatedSortItem.MinusreferenceName => "-referenceName",
                AppAssetLibrariesVideosGetToManyRelatedSortItem.CreatedDate => "createdDate",
                AppAssetLibrariesVideosGetToManyRelatedSortItem.LastModifiedDate => "lastModifiedDate",
                AppAssetLibrariesVideosGetToManyRelatedSortItem.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibrariesVideosGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-createdDate" => AppAssetLibrariesVideosGetToManyRelatedSortItem.MinuscreatedDate,
                "-lastModifiedDate" => AppAssetLibrariesVideosGetToManyRelatedSortItem.MinuslastModifiedDate,
                "-referenceName" => AppAssetLibrariesVideosGetToManyRelatedSortItem.MinusreferenceName,
                "createdDate" => AppAssetLibrariesVideosGetToManyRelatedSortItem.CreatedDate,
                "lastModifiedDate" => AppAssetLibrariesVideosGetToManyRelatedSortItem.LastModifiedDate,
                "referenceName" => AppAssetLibrariesVideosGetToManyRelatedSortItem.ReferenceName,
                _ => null,
            };
        }
    }
}