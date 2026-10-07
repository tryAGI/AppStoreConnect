
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem
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
    public static class AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem.AppEventLocalization => "appEventLocalization",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem.Image => "image",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization,
                "appEventLocalization" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem.AppStoreVersionLocalization,
                "image" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem.Image,
                "video" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedIncludeItem.Video,
                _ => null,
            };
        }
    }
}