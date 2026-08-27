
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppReviewSubmissionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        ReviewSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppReviewSubmissionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppReviewSubmissionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppReviewSubmissionsLinkagesResponseDataItemType.ReviewSubmissions => "reviewSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppReviewSubmissionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "reviewSubmissions" => AppReviewSubmissionsLinkagesResponseDataItemType.ReviewSubmissions,
                _ => null,
            };
        }
    }
}