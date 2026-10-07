
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem
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
    public static class AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem.MinuscreatedDate => "-createdDate",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem.MinuslastModifiedDate => "-lastModifiedDate",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem.MinusplacementGroupPosition => "-placementGroupPosition",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem.CreatedDate => "createdDate",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem.LastModifiedDate => "lastModifiedDate",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem.PlacementGroupPosition => "placementGroupPosition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-createdDate" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem.MinuscreatedDate,
                "-lastModifiedDate" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem.MinuslastModifiedDate,
                "-placementGroupPosition" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem.MinusplacementGroupPosition,
                "createdDate" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem.CreatedDate,
                "lastModifiedDate" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem.LastModifiedDate,
                "placementGroupPosition" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedSortItem.PlacementGroupPosition,
                _ => null,
            };
        }
    }
}