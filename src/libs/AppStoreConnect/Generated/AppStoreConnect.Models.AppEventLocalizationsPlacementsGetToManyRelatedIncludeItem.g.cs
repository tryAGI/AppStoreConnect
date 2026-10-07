
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem
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
    public static class AppEventLocalizationsPlacementsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem.AppEventLocalization => "appEventLocalization",
                AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem.Image => "image",
                AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization,
                "appEventLocalization" => AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem.AppStoreVersionLocalization,
                "image" => AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem.Image,
                "video" => AppEventLocalizationsPlacementsGetToManyRelatedIncludeItem.Video,
                _ => null,
            };
        }
    }
}