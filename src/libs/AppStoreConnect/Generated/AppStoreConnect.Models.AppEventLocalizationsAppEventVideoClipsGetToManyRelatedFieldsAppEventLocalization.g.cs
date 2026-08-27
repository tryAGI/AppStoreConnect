
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization
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
    public static class AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.AppEvent => "appEvent",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.Locale => "locale",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.LongDescription => "longDescription",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.Name => "name",
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.Locale,
                "longDescription" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.LongDescription,
                "name" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.Name,
                "shortDescription" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}