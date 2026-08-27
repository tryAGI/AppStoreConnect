
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization
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
    public static class AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.AppEvent => "appEvent",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.Locale => "locale",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.LongDescription => "longDescription",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.Name => "name",
                AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.Locale,
                "longDescription" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.LongDescription,
                "name" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.Name,
                "shortDescription" => AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}