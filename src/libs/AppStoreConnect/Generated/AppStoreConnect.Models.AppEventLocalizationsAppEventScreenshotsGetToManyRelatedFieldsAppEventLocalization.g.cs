
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization
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
    public static class AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.AppEvent => "appEvent",
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.Locale => "locale",
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.LongDescription => "longDescription",
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.Name => "name",
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.Locale,
                "longDescription" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.LongDescription,
                "name" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.Name,
                "shortDescription" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}