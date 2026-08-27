
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomerReviewsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Response,
        /// <summary>
        ///
        /// </summary>
        ReviewTerritory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewsGetInstanceIncludeItem value)
        {
            return value switch
            {
                CustomerReviewsGetInstanceIncludeItem.Response => "response",
                CustomerReviewsGetInstanceIncludeItem.ReviewTerritory => "reviewTerritory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "response" => CustomerReviewsGetInstanceIncludeItem.Response,
                "reviewTerritory" => CustomerReviewsGetInstanceIncludeItem.ReviewTerritory,
                _ => null,
            };
        }
    }
}