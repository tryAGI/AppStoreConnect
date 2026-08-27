
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAppStoreReviewDetailCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipAppStoreReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAppStoreReviewDetailCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAppStoreReviewDetailCreateRequestDataType value)
        {
            return value switch
            {
                AppClipAppStoreReviewDetailCreateRequestDataType.AppClipAppStoreReviewDetails => "appClipAppStoreReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAppStoreReviewDetailCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAppStoreReviewDetails" => AppClipAppStoreReviewDetailCreateRequestDataType.AppClipAppStoreReviewDetails,
                _ => null,
            };
        }
    }
}