
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomerReviewsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        CustomerReviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomerReviewsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomerReviewsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppCustomerReviewsLinkagesResponseDataItemType.CustomerReviews => "customerReviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomerReviewsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "customerReviews" => AppCustomerReviewsLinkagesResponseDataItemType.CustomerReviews,
                _ => null,
            };
        }
    }
}