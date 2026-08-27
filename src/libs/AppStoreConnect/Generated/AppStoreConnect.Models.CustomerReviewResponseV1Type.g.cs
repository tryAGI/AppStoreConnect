
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomerReviewResponseV1Type
    {
        /// <summary>
        ///
        /// </summary>
        CustomerReviewResponses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewResponseV1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewResponseV1Type value)
        {
            return value switch
            {
                CustomerReviewResponseV1Type.CustomerReviewResponses => "customerReviewResponses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewResponseV1Type? ToEnum(string value)
        {
            return value switch
            {
                "customerReviewResponses" => CustomerReviewResponseV1Type.CustomerReviewResponses,
                _ => null,
            };
        }
    }
}