
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataType.AppClips => "appClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClips" => AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDataType.AppClips,
                _ => null,
            };
        }
    }
}