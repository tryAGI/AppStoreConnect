
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventLocalizationsAppEventScreenshotsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppEventLocalization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationsAppEventScreenshotsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsAppEventScreenshotsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppEventLocalizationsAppEventScreenshotsGetToManyRelatedIncludeItem.AppEventLocalization => "appEventLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsAppEventScreenshotsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appEventLocalization" => AppEventLocalizationsAppEventScreenshotsGetToManyRelatedIncludeItem.AppEventLocalization,
                _ => null,
            };
        }
    }
}