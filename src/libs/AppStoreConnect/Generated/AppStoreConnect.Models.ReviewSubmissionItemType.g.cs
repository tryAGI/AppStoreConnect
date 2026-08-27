
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemType
    {
        /// <summary>
        ///
        /// </summary>
        ReviewSubmissionItems,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemType value)
        {
            return value switch
            {
                ReviewSubmissionItemType.ReviewSubmissionItems => "reviewSubmissionItems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemType? ToEnum(string value)
        {
            return value switch
            {
                "reviewSubmissionItems" => ReviewSubmissionItemType.ReviewSubmissionItems,
                _ => null,
            };
        }
    }
}