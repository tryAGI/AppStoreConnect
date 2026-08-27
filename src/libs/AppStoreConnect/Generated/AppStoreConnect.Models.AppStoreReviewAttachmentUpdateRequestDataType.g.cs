
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreReviewAttachmentUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreReviewAttachments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewAttachmentUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewAttachmentUpdateRequestDataType value)
        {
            return value switch
            {
                AppStoreReviewAttachmentUpdateRequestDataType.AppStoreReviewAttachments => "appStoreReviewAttachments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewAttachmentUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => AppStoreReviewAttachmentUpdateRequestDataType.AppStoreReviewAttachments,
                _ => null,
            };
        }
    }
}