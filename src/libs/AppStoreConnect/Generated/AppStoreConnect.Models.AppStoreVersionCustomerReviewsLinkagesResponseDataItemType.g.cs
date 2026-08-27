
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionCustomerReviewsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        CustomerReviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionCustomerReviewsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionCustomerReviewsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppStoreVersionCustomerReviewsLinkagesResponseDataItemType.CustomerReviews => "customerReviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionCustomerReviewsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "customerReviews" => AppStoreVersionCustomerReviewsLinkagesResponseDataItemType.CustomerReviews,
                _ => null,
            };
        }
    }
}