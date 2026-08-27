
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreReviewDetailAppStoreReviewAttachmentsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreReviewAttachments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewDetailAppStoreReviewAttachmentsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewDetailAppStoreReviewAttachmentsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppStoreReviewDetailAppStoreReviewAttachmentsLinkagesResponseDataItemType.AppStoreReviewAttachments => "appStoreReviewAttachments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewDetailAppStoreReviewAttachmentsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => AppStoreReviewDetailAppStoreReviewAttachmentsLinkagesResponseDataItemType.AppStoreReviewAttachments,
                _ => null,
            };
        }
    }
}