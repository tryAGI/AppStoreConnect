
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomerReviewResponseV1RelationshipsReviewDataType
    {
        /// <summary>
        ///
        /// </summary>
        CustomerReviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewResponseV1RelationshipsReviewDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewResponseV1RelationshipsReviewDataType value)
        {
            return value switch
            {
                CustomerReviewResponseV1RelationshipsReviewDataType.CustomerReviews => "customerReviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewResponseV1RelationshipsReviewDataType? ToEnum(string value)
        {
            return value switch
            {
                "customerReviews" => CustomerReviewResponseV1RelationshipsReviewDataType.CustomerReviews,
                _ => null,
            };
        }
    }
}