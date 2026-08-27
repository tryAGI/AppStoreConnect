
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomerReviewResponseLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomerReviewResponses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewResponseLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewResponseLinkageResponseDataType value)
        {
            return value switch
            {
                CustomerReviewResponseLinkageResponseDataType.CustomerReviewResponses => "customerReviewResponses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewResponseLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "customerReviewResponses" => CustomerReviewResponseLinkageResponseDataType.CustomerReviewResponses,
                _ => null,
            };
        }
    }
}