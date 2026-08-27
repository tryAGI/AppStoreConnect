
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreReviewAttachmentType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewAttachments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewAttachmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewAttachmentType value)
        {
            return value switch
            {
                AppStoreReviewAttachmentType.AppStoreReviewAttachments => "appStoreReviewAttachments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewAttachmentType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => AppStoreReviewAttachmentType.AppStoreReviewAttachments,
                _ => null,
            };
        }
    }
}