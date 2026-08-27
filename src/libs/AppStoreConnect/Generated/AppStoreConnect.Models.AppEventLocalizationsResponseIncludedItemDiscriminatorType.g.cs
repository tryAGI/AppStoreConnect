
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsResponseIncludedItemDiscriminatorType
    {
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
        AppEvents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppEventLocalizationsResponseIncludedItemDiscriminatorType.AppEventScreenshots => "appEventScreenshots",
                AppEventLocalizationsResponseIncludedItemDiscriminatorType.AppEventVideoClips => "appEventVideoClips",
                AppEventLocalizationsResponseIncludedItemDiscriminatorType.AppEvents => "appEvents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appEventScreenshots" => AppEventLocalizationsResponseIncludedItemDiscriminatorType.AppEventScreenshots,
                "appEventVideoClips" => AppEventLocalizationsResponseIncludedItemDiscriminatorType.AppEventVideoClips,
                "appEvents" => AppEventLocalizationsResponseIncludedItemDiscriminatorType.AppEvents,
                _ => null,
            };
        }
    }
}