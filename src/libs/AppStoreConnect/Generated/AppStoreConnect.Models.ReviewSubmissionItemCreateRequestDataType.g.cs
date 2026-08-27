
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        ReviewSubmissionItems,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataType.ReviewSubmissionItems => "reviewSubmissionItems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "reviewSubmissionItems" => ReviewSubmissionItemCreateRequestDataType.ReviewSubmissionItems,
                _ => null,
            };
        }
    }
}