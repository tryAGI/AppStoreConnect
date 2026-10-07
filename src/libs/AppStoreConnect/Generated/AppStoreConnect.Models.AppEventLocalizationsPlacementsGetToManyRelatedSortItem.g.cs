
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsPlacementsGetToManyRelatedSortItem
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
    public static class AppEventLocalizationsPlacementsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsPlacementsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppEventLocalizationsPlacementsGetToManyRelatedSortItem.MinuscreatedDate => "-createdDate",
                AppEventLocalizationsPlacementsGetToManyRelatedSortItem.MinuslastModifiedDate => "-lastModifiedDate",
                AppEventLocalizationsPlacementsGetToManyRelatedSortItem.MinusplacementGroupPosition => "-placementGroupPosition",
                AppEventLocalizationsPlacementsGetToManyRelatedSortItem.CreatedDate => "createdDate",
                AppEventLocalizationsPlacementsGetToManyRelatedSortItem.LastModifiedDate => "lastModifiedDate",
                AppEventLocalizationsPlacementsGetToManyRelatedSortItem.PlacementGroupPosition => "placementGroupPosition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsPlacementsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-createdDate" => AppEventLocalizationsPlacementsGetToManyRelatedSortItem.MinuscreatedDate,
                "-lastModifiedDate" => AppEventLocalizationsPlacementsGetToManyRelatedSortItem.MinuslastModifiedDate,
                "-placementGroupPosition" => AppEventLocalizationsPlacementsGetToManyRelatedSortItem.MinusplacementGroupPosition,
                "createdDate" => AppEventLocalizationsPlacementsGetToManyRelatedSortItem.CreatedDate,
                "lastModifiedDate" => AppEventLocalizationsPlacementsGetToManyRelatedSortItem.LastModifiedDate,
                "placementGroupPosition" => AppEventLocalizationsPlacementsGetToManyRelatedSortItem.PlacementGroupPosition,
                _ => null,
            };
        }
    }
}