
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomerReviewType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomerReviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewType value)
        {
            return value switch
            {
                CustomerReviewType.CustomerReviews => "customerReviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewType? ToEnum(string value)
        {
            return value switch
            {
                "customerReviews" => CustomerReviewType.CustomerReviews,
                _ => null,
            };
        }
    }
}