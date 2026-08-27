
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomerReviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataType value)
        {
            return value switch
            {
                CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataType.CustomerReviews => "customerReviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataType? ToEnum(string value)
        {
            return value switch
            {
                "customerReviews" => CustomerReviewResponseV1CreateRequestDataRelationshipsReviewDataType.CustomerReviews,
                _ => null,
            };
        }
    }
}