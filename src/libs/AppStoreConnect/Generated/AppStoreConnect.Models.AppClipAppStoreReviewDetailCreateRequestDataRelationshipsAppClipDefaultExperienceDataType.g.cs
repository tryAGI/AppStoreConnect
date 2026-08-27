
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAppStoreReviewDetailCreateRequestDataRelationshipsAppClipDefaultExperienceDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAppStoreReviewDetailCreateRequestDataRelationshipsAppClipDefaultExperienceDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAppStoreReviewDetailCreateRequestDataRelationshipsAppClipDefaultExperienceDataType value)
        {
            return value switch
            {
                AppClipAppStoreReviewDetailCreateRequestDataRelationshipsAppClipDefaultExperienceDataType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAppStoreReviewDetailCreateRequestDataRelationshipsAppClipDefaultExperienceDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppClipAppStoreReviewDetailCreateRequestDataRelationshipsAppClipDefaultExperienceDataType.AppClipDefaultExperiences,
                _ => null,
            };
        }
    }
}