
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceCreateRequestDataType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceCreateRequestDataType.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperiences" => AppClipAdvancedExperienceCreateRequestDataType.AppClipAdvancedExperiences,
                _ => null,
            };
        }
    }
}