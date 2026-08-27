
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperienceImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType.AppClipAdvancedExperienceImages => "appClipAdvancedExperienceImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperienceImages" => AppClipAdvancedExperienceUpdateRequestDataRelationshipsHeaderImageDataType.AppClipAdvancedExperienceImages,
                _ => null,
            };
        }
    }
}