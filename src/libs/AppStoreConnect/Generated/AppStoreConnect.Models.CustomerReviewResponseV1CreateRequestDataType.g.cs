
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomerReviewResponseV1CreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        CustomerReviewResponses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewResponseV1CreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewResponseV1CreateRequestDataType value)
        {
            return value switch
            {
                CustomerReviewResponseV1CreateRequestDataType.CustomerReviewResponses => "customerReviewResponses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewResponseV1CreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "customerReviewResponses" => CustomerReviewResponseV1CreateRequestDataType.CustomerReviewResponses,
                _ => null,
            };
        }
    }
}