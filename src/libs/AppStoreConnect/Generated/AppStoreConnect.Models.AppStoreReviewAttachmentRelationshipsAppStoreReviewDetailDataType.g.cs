
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataType value)
        {
            return value switch
            {
                AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataType.AppStoreReviewDetails => "appStoreReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewDetails" => AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataType.AppStoreReviewDetails,
                _ => null,
            };
        }
    }
}