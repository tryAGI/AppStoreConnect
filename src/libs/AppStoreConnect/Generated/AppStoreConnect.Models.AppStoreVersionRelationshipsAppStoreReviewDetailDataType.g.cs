
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionRelationshipsAppStoreReviewDetailDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionRelationshipsAppStoreReviewDetailDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionRelationshipsAppStoreReviewDetailDataType value)
        {
            return value switch
            {
                AppStoreVersionRelationshipsAppStoreReviewDetailDataType.AppStoreReviewDetails => "appStoreReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionRelationshipsAppStoreReviewDetailDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewDetails" => AppStoreVersionRelationshipsAppStoreReviewDetailDataType.AppStoreReviewDetails,
                _ => null,
            };
        }
    }
}