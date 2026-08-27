
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventVideoClipsGetInstanceFieldsAppEventLocalization
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
    public static class AppEventVideoClipsGetInstanceFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventVideoClipsGetInstanceFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppEventVideoClipsGetInstanceFieldsAppEventLocalization.AppEvent => "appEvent",
                AppEventVideoClipsGetInstanceFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppEventVideoClipsGetInstanceFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppEventVideoClipsGetInstanceFieldsAppEventLocalization.Locale => "locale",
                AppEventVideoClipsGetInstanceFieldsAppEventLocalization.LongDescription => "longDescription",
                AppEventVideoClipsGetInstanceFieldsAppEventLocalization.Name => "name",
                AppEventVideoClipsGetInstanceFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventVideoClipsGetInstanceFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppEventVideoClipsGetInstanceFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppEventVideoClipsGetInstanceFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppEventVideoClipsGetInstanceFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppEventVideoClipsGetInstanceFieldsAppEventLocalization.Locale,
                "longDescription" => AppEventVideoClipsGetInstanceFieldsAppEventLocalization.LongDescription,
                "name" => AppEventVideoClipsGetInstanceFieldsAppEventLocalization.Name,
                "shortDescription" => AppEventVideoClipsGetInstanceFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}