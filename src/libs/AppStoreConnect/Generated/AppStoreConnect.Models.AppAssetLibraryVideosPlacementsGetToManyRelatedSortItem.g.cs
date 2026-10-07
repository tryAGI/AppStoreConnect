
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem
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
        MinusplacementGroupPosition,
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
        PlacementGroupPosition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryVideosPlacementsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem.MinuscreatedDate => "-createdDate",
                AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem.MinuslastModifiedDate => "-lastModifiedDate",
                AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem.MinusplacementGroupPosition => "-placementGroupPosition",
                AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem.CreatedDate => "createdDate",
                AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem.PlacementGroupPosition => "placementGroupPosition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-createdDate" => AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem.MinuscreatedDate,
                "-lastModifiedDate" => AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem.MinuslastModifiedDate,
                "-placementGroupPosition" => AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem.MinusplacementGroupPosition,
                "createdDate" => AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem.CreatedDate,
                "lastModifiedDate" => AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem.LastModifiedDate,
                "placementGroupPosition" => AppAssetLibraryVideosPlacementsGetToManyRelatedSortItem.PlacementGroupPosition,
                _ => null,
            };
        }
    }
}