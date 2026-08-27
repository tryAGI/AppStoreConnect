
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomerReviewRelationshipsResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomerReviewResponses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewRelationshipsResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewRelationshipsResponseDataType value)
        {
            return value switch
            {
                CustomerReviewRelationshipsResponseDataType.CustomerReviewResponses => "customerReviewResponses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewRelationshipsResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "customerReviewResponses" => CustomerReviewRelationshipsResponseDataType.CustomerReviewResponses,
                _ => null,
            };
        }
    }
}