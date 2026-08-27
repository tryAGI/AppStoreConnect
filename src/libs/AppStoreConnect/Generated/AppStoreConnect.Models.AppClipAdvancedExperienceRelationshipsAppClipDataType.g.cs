
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceRelationshipsAppClipDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceRelationshipsAppClipDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceRelationshipsAppClipDataType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceRelationshipsAppClipDataType.AppClips => "appClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceRelationshipsAppClipDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClips" => AppClipAdvancedExperienceRelationshipsAppClipDataType.AppClips,
                _ => null,
            };
        }
    }
}