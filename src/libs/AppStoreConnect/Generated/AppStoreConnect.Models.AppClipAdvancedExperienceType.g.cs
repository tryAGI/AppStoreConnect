
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceType.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperiences" => AppClipAdvancedExperienceType.AppClipAdvancedExperiences,
                _ => null,
            };
        }
    }
}