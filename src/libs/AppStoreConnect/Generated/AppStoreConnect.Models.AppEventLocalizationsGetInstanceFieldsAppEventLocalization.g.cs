
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsGetInstanceFieldsAppEventLocalization
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
    public static class AppEventLocalizationsGetInstanceFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsGetInstanceFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppEventLocalizationsGetInstanceFieldsAppEventLocalization.AppEvent => "appEvent",
                AppEventLocalizationsGetInstanceFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppEventLocalizationsGetInstanceFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppEventLocalizationsGetInstanceFieldsAppEventLocalization.Locale => "locale",
                AppEventLocalizationsGetInstanceFieldsAppEventLocalization.LongDescription => "longDescription",
                AppEventLocalizationsGetInstanceFieldsAppEventLocalization.Name => "name",
                AppEventLocalizationsGetInstanceFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsGetInstanceFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppEventLocalizationsGetInstanceFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppEventLocalizationsGetInstanceFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppEventLocalizationsGetInstanceFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppEventLocalizationsGetInstanceFieldsAppEventLocalization.Locale,
                "longDescription" => AppEventLocalizationsGetInstanceFieldsAppEventLocalization.LongDescription,
                "name" => AppEventLocalizationsGetInstanceFieldsAppEventLocalization.Name,
                "shortDescription" => AppEventLocalizationsGetInstanceFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}