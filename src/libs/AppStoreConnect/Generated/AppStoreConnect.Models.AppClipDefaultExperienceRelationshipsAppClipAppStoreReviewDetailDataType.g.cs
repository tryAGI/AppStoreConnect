
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAppStoreReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType.AppClipAppStoreReviewDetails => "appClipAppStoreReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAppStoreReviewDetails" => AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType.AppClipAppStoreReviewDetails,
                _ => null,
            };
        }
    }
}