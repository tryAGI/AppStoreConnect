
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem
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
    public static class AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem.MinuscreatedDate => "-createdDate",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem.MinuslastModifiedDate => "-lastModifiedDate",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem.MinusplacementGroupPosition => "-placementGroupPosition",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem.CreatedDate => "createdDate",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem.LastModifiedDate => "lastModifiedDate",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem.PlacementGroupPosition => "placementGroupPosition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-createdDate" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem.MinuscreatedDate,
                "-lastModifiedDate" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem.MinuslastModifiedDate,
                "-placementGroupPosition" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem.MinusplacementGroupPosition,
                "createdDate" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem.CreatedDate,
                "lastModifiedDate" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem.LastModifiedDate,
                "placementGroupPosition" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedSortItem.PlacementGroupPosition,
                _ => null,
            };
        }
    }
}