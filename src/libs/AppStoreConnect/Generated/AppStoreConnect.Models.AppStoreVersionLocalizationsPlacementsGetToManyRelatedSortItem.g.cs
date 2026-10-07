
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem
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
    public static class AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem.MinuscreatedDate => "-createdDate",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem.MinuslastModifiedDate => "-lastModifiedDate",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem.MinusplacementGroupPosition => "-placementGroupPosition",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem.CreatedDate => "createdDate",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem.LastModifiedDate => "lastModifiedDate",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem.PlacementGroupPosition => "placementGroupPosition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-createdDate" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem.MinuscreatedDate,
                "-lastModifiedDate" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem.MinuslastModifiedDate,
                "-placementGroupPosition" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem.MinusplacementGroupPosition,
                "createdDate" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem.CreatedDate,
                "lastModifiedDate" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem.LastModifiedDate,
                "placementGroupPosition" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedSortItem.PlacementGroupPosition,
                _ => null,
            };
        }
    }
}