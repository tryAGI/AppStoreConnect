
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem
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
    public static class AppAssetLibraryImagesPlacementsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem.MinuscreatedDate => "-createdDate",
                AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem.MinuslastModifiedDate => "-lastModifiedDate",
                AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem.MinusplacementGroupPosition => "-placementGroupPosition",
                AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem.CreatedDate => "createdDate",
                AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem.PlacementGroupPosition => "placementGroupPosition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-createdDate" => AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem.MinuscreatedDate,
                "-lastModifiedDate" => AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem.MinuslastModifiedDate,
                "-placementGroupPosition" => AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem.MinusplacementGroupPosition,
                "createdDate" => AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem.CreatedDate,
                "lastModifiedDate" => AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem.LastModifiedDate,
                "placementGroupPosition" => AppAssetLibraryImagesPlacementsGetToManyRelatedSortItem.PlacementGroupPosition,
                _ => null,
            };
        }
    }
}