
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceImageCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperienceImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceImageCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceImageCreateRequestDataType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceImageCreateRequestDataType.AppClipAdvancedExperienceImages => "appClipAdvancedExperienceImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceImageCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperienceImages" => AppClipAdvancedExperienceImageCreateRequestDataType.AppClipAdvancedExperienceImages,
                _ => null,
            };
        }
    }
}