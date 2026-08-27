
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreReviewDetailResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewAttachments,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewDetailResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewDetailResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppStoreReviewDetailResponseIncludedItemDiscriminatorType.AppStoreReviewAttachments => "appStoreReviewAttachments",
                AppStoreReviewDetailResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewDetailResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => AppStoreReviewDetailResponseIncludedItemDiscriminatorType.AppStoreReviewAttachments,
                "appStoreVersions" => AppStoreReviewDetailResponseIncludedItemDiscriminatorType.AppStoreVersions,
                _ => null,
            };
        }
    }
}