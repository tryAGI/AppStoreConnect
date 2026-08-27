
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppRelationshipsAppClipsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsAppClipsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsAppClipsDataItemType value)
        {
            return value switch
            {
                AppRelationshipsAppClipsDataItemType.AppClips => "appClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsAppClipsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appClips" => AppRelationshipsAppClipsDataItemType.AppClips,
                _ => null,
            };
        }
    }
}