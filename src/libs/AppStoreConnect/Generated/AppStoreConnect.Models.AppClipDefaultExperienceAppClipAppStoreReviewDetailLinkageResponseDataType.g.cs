
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperienceAppClipAppStoreReviewDetailLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipAppStoreReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceAppClipAppStoreReviewDetailLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceAppClipAppStoreReviewDetailLinkageResponseDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceAppClipAppStoreReviewDetailLinkageResponseDataType.AppClipAppStoreReviewDetails => "appClipAppStoreReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceAppClipAppStoreReviewDetailLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAppStoreReviewDetails" => AppClipDefaultExperienceAppClipAppStoreReviewDetailLinkageResponseDataType.AppClipAppStoreReviewDetails,
                _ => null,
            };
        }
    }
}