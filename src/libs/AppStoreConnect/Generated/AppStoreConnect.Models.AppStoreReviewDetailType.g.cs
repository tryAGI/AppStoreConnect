
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreReviewDetailType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewDetailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewDetailType value)
        {
            return value switch
            {
                AppStoreReviewDetailType.AppStoreReviewDetails => "appStoreReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewDetailType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewDetails" => AppStoreReviewDetailType.AppStoreReviewDetails,
                _ => null,
            };
        }
    }
}