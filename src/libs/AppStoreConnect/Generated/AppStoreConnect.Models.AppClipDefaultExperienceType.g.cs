
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceType value)
        {
            return value switch
            {
                AppClipDefaultExperienceType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppClipDefaultExperienceType.AppClipDefaultExperiences,
                _ => null,
            };
        }
    }
}