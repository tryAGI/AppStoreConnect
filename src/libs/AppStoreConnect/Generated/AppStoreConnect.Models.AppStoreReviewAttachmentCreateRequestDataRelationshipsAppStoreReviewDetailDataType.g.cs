
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreReviewAttachmentCreateRequestDataRelationshipsAppStoreReviewDetailDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewAttachmentCreateRequestDataRelationshipsAppStoreReviewDetailDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewAttachmentCreateRequestDataRelationshipsAppStoreReviewDetailDataType value)
        {
            return value switch
            {
                AppStoreReviewAttachmentCreateRequestDataRelationshipsAppStoreReviewDetailDataType.AppStoreReviewDetails => "appStoreReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewAttachmentCreateRequestDataRelationshipsAppStoreReviewDetailDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewDetails" => AppStoreReviewAttachmentCreateRequestDataRelationshipsAppStoreReviewDetailDataType.AppStoreReviewDetails,
                _ => null,
            };
        }
    }
}