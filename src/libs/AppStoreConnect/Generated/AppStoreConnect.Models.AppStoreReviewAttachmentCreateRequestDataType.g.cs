
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreReviewAttachmentCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewAttachments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewAttachmentCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewAttachmentCreateRequestDataType value)
        {
            return value switch
            {
                AppStoreReviewAttachmentCreateRequestDataType.AppStoreReviewAttachments => "appStoreReviewAttachments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewAttachmentCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => AppStoreReviewAttachmentCreateRequestDataType.AppStoreReviewAttachments,
                _ => null,
            };
        }
    }
}