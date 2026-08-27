
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplateDataType.AppClipDefaultExperiences,
                _ => null,
            };
        }
    }
}