
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAppStoreReviewDetailType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAppStoreReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAppStoreReviewDetailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAppStoreReviewDetailType value)
        {
            return value switch
            {
                AppClipAppStoreReviewDetailType.AppClipAppStoreReviewDetails => "appClipAppStoreReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAppStoreReviewDetailType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAppStoreReviewDetails" => AppClipAppStoreReviewDetailType.AppClipAppStoreReviewDetails,
                _ => null,
            };
        }
    }
}