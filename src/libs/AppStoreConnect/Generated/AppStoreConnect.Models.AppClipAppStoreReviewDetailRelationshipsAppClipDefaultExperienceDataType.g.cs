
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType value)
        {
            return value switch
            {
                AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType.AppClipDefaultExperiences,
                _ => null,
            };
        }
    }
}