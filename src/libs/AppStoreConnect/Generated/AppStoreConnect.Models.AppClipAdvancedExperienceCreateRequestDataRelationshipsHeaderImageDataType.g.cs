
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperienceImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataType.AppClipAdvancedExperienceImages => "appClipAdvancedExperienceImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperienceImages" => AppClipAdvancedExperienceCreateRequestDataRelationshipsHeaderImageDataType.AppClipAdvancedExperienceImages,
                _ => null,
            };
        }
    }
}