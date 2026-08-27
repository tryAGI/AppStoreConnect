
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventsGetInstanceFieldsAppEventLocalization
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
    public static class AppEventsGetInstanceFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventsGetInstanceFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppEventsGetInstanceFieldsAppEventLocalization.AppEvent => "appEvent",
                AppEventsGetInstanceFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppEventsGetInstanceFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppEventsGetInstanceFieldsAppEventLocalization.Locale => "locale",
                AppEventsGetInstanceFieldsAppEventLocalization.LongDescription => "longDescription",
                AppEventsGetInstanceFieldsAppEventLocalization.Name => "name",
                AppEventsGetInstanceFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventsGetInstanceFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppEventsGetInstanceFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppEventsGetInstanceFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppEventsGetInstanceFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppEventsGetInstanceFieldsAppEventLocalization.Locale,
                "longDescription" => AppEventsGetInstanceFieldsAppEventLocalization.LongDescription,
                "name" => AppEventsGetInstanceFieldsAppEventLocalization.Name,
                "shortDescription" => AppEventsGetInstanceFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}