
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem
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
    public static class AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppPreviews => "appPreviews",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppStoreVersionLocalization => "appStoreVersionLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization,
                "appPreviews" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppPreviews,
                "appStoreVersionExperimentTreatmentLocalization" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem.AppStoreVersionLocalization,
                _ => null,
            };
        }
    }
}