
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewAttachments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType value)
        {
            return value switch
            {
                AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType.AppStoreReviewAttachments => "appStoreReviewAttachments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType.AppStoreReviewAttachments,
                _ => null,
            };
        }
    }
}