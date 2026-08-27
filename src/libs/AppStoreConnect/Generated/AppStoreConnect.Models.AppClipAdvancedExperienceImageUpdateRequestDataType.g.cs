
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceImageUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperienceImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceImageUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceImageUpdateRequestDataType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceImageUpdateRequestDataType.AppClipAdvancedExperienceImages => "appClipAdvancedExperienceImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceImageUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperienceImages" => AppClipAdvancedExperienceImageUpdateRequestDataType.AppClipAdvancedExperienceImages,
                _ => null,
            };
        }
    }
}