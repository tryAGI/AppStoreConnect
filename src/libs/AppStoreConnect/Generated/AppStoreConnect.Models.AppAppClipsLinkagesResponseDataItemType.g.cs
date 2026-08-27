
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAppClipsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAppClipsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAppClipsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppAppClipsLinkagesResponseDataItemType.AppClips => "appClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAppClipsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appClips" => AppAppClipsLinkagesResponseDataItemType.AppClips,
                _ => null,
            };
        }
    }
}