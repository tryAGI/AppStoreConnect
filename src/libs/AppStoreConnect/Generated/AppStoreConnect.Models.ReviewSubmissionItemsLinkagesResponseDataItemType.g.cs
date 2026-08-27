
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        ReviewSubmissionItems,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                ReviewSubmissionItemsLinkagesResponseDataItemType.ReviewSubmissionItems => "reviewSubmissionItems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "reviewSubmissionItems" => ReviewSubmissionItemsLinkagesResponseDataItemType.ReviewSubmissionItems,
                _ => null,
            };
        }
    }
}