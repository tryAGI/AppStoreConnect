
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipAdvancedExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceUpdateRequestDataType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceUpdateRequestDataType.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperiences" => AppClipAdvancedExperienceUpdateRequestDataType.AppClipAdvancedExperiences,
                _ => null,
            };
        }
    }
}