
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomerReviewsResponseGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Review,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewsResponseGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewsResponseGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                CustomerReviewsResponseGetToOneRelatedIncludeItem.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewsResponseGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "review" => CustomerReviewsResponseGetToOneRelatedIncludeItem.Review,
                _ => null,
            };
        }
    }
}