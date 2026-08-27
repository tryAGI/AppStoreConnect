
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataType.AppClips => "appClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClips" => AppClipAdvancedExperienceCreateRequestDataRelationshipsAppClipDataType.AppClips,
                _ => null,
            };
        }
    }
}