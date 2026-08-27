
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionAppStoreReviewDetailLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionAppStoreReviewDetailLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionAppStoreReviewDetailLinkageResponseDataType value)
        {
            return value switch
            {
                AppStoreVersionAppStoreReviewDetailLinkageResponseDataType.AppStoreReviewDetails => "appStoreReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionAppStoreReviewDetailLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewDetails" => AppStoreVersionAppStoreReviewDetailLinkageResponseDataType.AppStoreReviewDetails,
                _ => null,
            };
        }
    }
}