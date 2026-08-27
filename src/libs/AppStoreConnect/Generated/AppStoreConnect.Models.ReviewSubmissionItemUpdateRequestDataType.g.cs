
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        ReviewSubmissionItems,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemUpdateRequestDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemUpdateRequestDataType.ReviewSubmissionItems => "reviewSubmissionItems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "reviewSubmissionItems" => ReviewSubmissionItemUpdateRequestDataType.ReviewSubmissionItems,
                _ => null,
            };
        }
    }
}