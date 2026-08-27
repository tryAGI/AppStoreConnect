
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomerReviewResponsesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Review,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewResponsesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewResponsesGetInstanceIncludeItem value)
        {
            return value switch
            {
                CustomerReviewResponsesGetInstanceIncludeItem.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewResponsesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "review" => CustomerReviewResponsesGetInstanceIncludeItem.Review,
                _ => null,
            };
        }
    }
}