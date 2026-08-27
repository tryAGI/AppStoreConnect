
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppEventsGetToManyRelatedFieldsAppEventLocalization
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
    public static class AppsAppEventsGetToManyRelatedFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppEventsGetToManyRelatedFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.AppEvent => "appEvent",
                AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.Locale => "locale",
                AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.LongDescription => "longDescription",
                AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.Name => "name",
                AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppEventsGetToManyRelatedFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.Locale,
                "longDescription" => AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.LongDescription,
                "name" => AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.Name,
                "shortDescription" => AppsAppEventsGetToManyRelatedFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}