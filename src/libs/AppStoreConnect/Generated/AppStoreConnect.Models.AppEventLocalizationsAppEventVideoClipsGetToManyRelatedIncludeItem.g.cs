
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsAppEventVideoClipsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppEventLocalization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationsAppEventVideoClipsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsAppEventVideoClipsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppEventLocalizationsAppEventVideoClipsGetToManyRelatedIncludeItem.AppEventLocalization => "appEventLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsAppEventVideoClipsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appEventLocalization" => AppEventLocalizationsAppEventVideoClipsGetToManyRelatedIncludeItem.AppEventLocalization,
                _ => null,
            };
        }
    }
}