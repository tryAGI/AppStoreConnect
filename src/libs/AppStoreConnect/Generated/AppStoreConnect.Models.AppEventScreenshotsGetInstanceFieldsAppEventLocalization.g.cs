
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventScreenshotsGetInstanceFieldsAppEventLocalization
    {
        /// <summary>
        /// 
        /// </summary>
        AppEvent,
        /// <summary>
        /// 
        /// </summary>
        AppEventScreenshots,
        /// <summary>
        /// 
        /// </summary>
        AppEventVideoClips,
        /// <summary>
        /// 
        /// </summary>
        Locale,
        /// <summary>
        /// 
        /// </summary>
        LongDescription,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        ShortDescription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventScreenshotsGetInstanceFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventScreenshotsGetInstanceFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppEventScreenshotsGetInstanceFieldsAppEventLocalization.AppEvent => "appEvent",
                AppEventScreenshotsGetInstanceFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppEventScreenshotsGetInstanceFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppEventScreenshotsGetInstanceFieldsAppEventLocalization.Locale => "locale",
                AppEventScreenshotsGetInstanceFieldsAppEventLocalization.LongDescription => "longDescription",
                AppEventScreenshotsGetInstanceFieldsAppEventLocalization.Name => "name",
                AppEventScreenshotsGetInstanceFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventScreenshotsGetInstanceFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppEventScreenshotsGetInstanceFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppEventScreenshotsGetInstanceFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppEventScreenshotsGetInstanceFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppEventScreenshotsGetInstanceFieldsAppEventLocalization.Locale,
                "longDescription" => AppEventScreenshotsGetInstanceFieldsAppEventLocalization.LongDescription,
                "name" => AppEventScreenshotsGetInstanceFieldsAppEventLocalization.Name,
                "shortDescription" => AppEventScreenshotsGetInstanceFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}