
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceImageType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperienceImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceImageType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceImageType.AppClipAdvancedExperienceImages => "appClipAdvancedExperienceImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceImageType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperienceImages" => AppClipAdvancedExperienceImageType.AppClipAdvancedExperienceImages,
                _ => null,
            };
        }
    }
}