
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventLocalizationResponseIncludedItemDiscriminatorType
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
    public static class AppEventLocalizationResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppEventLocalizationResponseIncludedItemDiscriminatorType.AppEventScreenshots => "appEventScreenshots",
                AppEventLocalizationResponseIncludedItemDiscriminatorType.AppEventVideoClips => "appEventVideoClips",
                AppEventLocalizationResponseIncludedItemDiscriminatorType.AppEvents => "appEvents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appEventScreenshots" => AppEventLocalizationResponseIncludedItemDiscriminatorType.AppEventScreenshots,
                "appEventVideoClips" => AppEventLocalizationResponseIncludedItemDiscriminatorType.AppEventVideoClips,
                "appEvents" => AppEventLocalizationResponseIncludedItemDiscriminatorType.AppEvents,
                _ => null,
            };
        }
    }
}