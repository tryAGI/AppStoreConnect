
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        ReviewSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionUpdateRequestDataType value)
        {
            return value switch
            {
                ReviewSubmissionUpdateRequestDataType.ReviewSubmissions => "reviewSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "reviewSubmissions" => ReviewSubmissionUpdateRequestDataType.ReviewSubmissions,
                _ => null,
            };
        }
    }
}