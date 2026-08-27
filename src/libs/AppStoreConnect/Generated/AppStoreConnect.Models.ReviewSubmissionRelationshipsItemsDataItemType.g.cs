
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionRelationshipsItemsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ReviewSubmissionItems,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionRelationshipsItemsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionRelationshipsItemsDataItemType value)
        {
            return value switch
            {
                ReviewSubmissionRelationshipsItemsDataItemType.ReviewSubmissionItems => "reviewSubmissionItems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionRelationshipsItemsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "reviewSubmissionItems" => ReviewSubmissionRelationshipsItemsDataItemType.ReviewSubmissionItems,
                _ => null,
            };
        }
    }
}