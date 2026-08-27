
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataType.AppClips => "appClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClips" => AppClipAdvancedExperienceUpdateRequestDataRelationshipsAppClipDataType.AppClips,
                _ => null,
            };
        }
    }
}