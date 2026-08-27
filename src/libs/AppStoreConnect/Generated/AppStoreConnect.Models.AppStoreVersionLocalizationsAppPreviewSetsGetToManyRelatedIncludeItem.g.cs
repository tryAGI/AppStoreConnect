
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalization,
        /// <summary>
        ///
        /// </summary>
        AppPreviews,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatmentLocalization,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppPreviews => "appPreviews",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppStoreVersionLocalization => "appStoreVersionLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization,
                "appPreviews" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppPreviews,
                "appStoreVersionExperimentTreatmentLocalization" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppStoreVersionLocalization,
                _ => null,
            };
        }
    }
}