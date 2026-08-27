
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreReviewDetailCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewDetailCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewDetailCreateRequestDataType value)
        {
            return value switch
            {
                AppStoreReviewDetailCreateRequestDataType.AppStoreReviewDetails => "appStoreReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewDetailCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewDetails" => AppStoreReviewDetailCreateRequestDataType.AppStoreReviewDetails,
                _ => null,
            };
        }
    }
}