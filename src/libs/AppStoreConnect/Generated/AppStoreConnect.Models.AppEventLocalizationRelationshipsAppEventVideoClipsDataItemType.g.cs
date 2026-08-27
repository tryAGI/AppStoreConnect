
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationRelationshipsAppEventVideoClipsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventVideoClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationRelationshipsAppEventVideoClipsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationRelationshipsAppEventVideoClipsDataItemType value)
        {
            return value switch
            {
                AppEventLocalizationRelationshipsAppEventVideoClipsDataItemType.AppEventVideoClips => "appEventVideoClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationRelationshipsAppEventVideoClipsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appEventVideoClips" => AppEventLocalizationRelationshipsAppEventVideoClipsDataItemType.AppEventVideoClips,
                _ => null,
            };
        }
    }
}