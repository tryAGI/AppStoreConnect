
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomerReviewsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        CustomerReviewResponses,
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                CustomerReviewsResponseIncludedItemDiscriminatorType.CustomerReviewResponses => "customerReviewResponses",
                CustomerReviewsResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "customerReviewResponses" => CustomerReviewsResponseIncludedItemDiscriminatorType.CustomerReviewResponses,
                "territories" => CustomerReviewsResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}