
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationAppEventVideoClipsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventVideoClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationAppEventVideoClipsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationAppEventVideoClipsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppEventLocalizationAppEventVideoClipsLinkagesResponseDataItemType.AppEventVideoClips => "appEventVideoClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationAppEventVideoClipsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appEventVideoClips" => AppEventLocalizationAppEventVideoClipsLinkagesResponseDataItemType.AppEventVideoClips,
                _ => null,
            };
        }
    }
}