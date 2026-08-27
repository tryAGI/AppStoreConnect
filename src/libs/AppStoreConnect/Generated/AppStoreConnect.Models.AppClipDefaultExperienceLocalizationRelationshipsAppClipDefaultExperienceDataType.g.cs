
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType.AppClipDefaultExperiences,
                _ => null,
            };
        }
    }
}