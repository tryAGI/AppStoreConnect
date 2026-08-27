
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomerReviewResponseIncludedItemDiscriminatorType
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
    public static class CustomerReviewResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                CustomerReviewResponseIncludedItemDiscriminatorType.CustomerReviewResponses => "customerReviewResponses",
                CustomerReviewResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "customerReviewResponses" => CustomerReviewResponseIncludedItemDiscriminatorType.CustomerReviewResponses,
                "territories" => CustomerReviewResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}