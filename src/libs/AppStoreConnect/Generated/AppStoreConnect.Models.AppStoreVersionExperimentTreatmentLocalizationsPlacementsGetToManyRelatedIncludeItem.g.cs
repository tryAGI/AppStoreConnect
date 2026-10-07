
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalization,
        /// <summary>
        ///
        /// </summary>
        AppEventLocalization,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatmentLocalization,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalization,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem.AppEventLocalization => "appEventLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem.Image => "image",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization,
                "appEventLocalization" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem.AppStoreVersionLocalization,
                "image" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem.Image,
                "video" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedIncludeItem.Video,
                _ => null,
            };
        }
    }
}