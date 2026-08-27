
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionRelationshipsAppClipDefaultExperienceDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionRelationshipsAppClipDefaultExperienceDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionRelationshipsAppClipDefaultExperienceDataType value)
        {
            return value switch
            {
                AppStoreVersionRelationshipsAppClipDefaultExperienceDataType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionRelationshipsAppClipDefaultExperienceDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppStoreVersionRelationshipsAppClipDefaultExperienceDataType.AppClipDefaultExperiences,
                _ => null,
            };
        }
    }
}