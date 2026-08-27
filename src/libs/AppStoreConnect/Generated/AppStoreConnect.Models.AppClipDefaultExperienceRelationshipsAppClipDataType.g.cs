
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceRelationshipsAppClipDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceRelationshipsAppClipDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceRelationshipsAppClipDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceRelationshipsAppClipDataType.AppClips => "appClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceRelationshipsAppClipDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClips" => AppClipDefaultExperienceRelationshipsAppClipDataType.AppClips,
                _ => null,
            };
        }
    }
}