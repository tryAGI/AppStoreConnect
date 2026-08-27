
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceLocalizationCreateRequestDataRelationshipsAppClipDefaultExperienceDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceLocalizationCreateRequestDataRelationshipsAppClipDefaultExperienceDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceLocalizationCreateRequestDataRelationshipsAppClipDefaultExperienceDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceLocalizationCreateRequestDataRelationshipsAppClipDefaultExperienceDataType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceLocalizationCreateRequestDataRelationshipsAppClipDefaultExperienceDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppClipDefaultExperienceLocalizationCreateRequestDataRelationshipsAppClipDefaultExperienceDataType.AppClipDefaultExperiences,
                _ => null,
            };
        }
    }
}