
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAppStoreReviewDetailUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAppStoreReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAppStoreReviewDetailUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAppStoreReviewDetailUpdateRequestDataType value)
        {
            return value switch
            {
                AppClipAppStoreReviewDetailUpdateRequestDataType.AppClipAppStoreReviewDetails => "appClipAppStoreReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAppStoreReviewDetailUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAppStoreReviewDetails" => AppClipAppStoreReviewDetailUpdateRequestDataType.AppClipAppStoreReviewDetails,
                _ => null,
            };
        }
    }
}