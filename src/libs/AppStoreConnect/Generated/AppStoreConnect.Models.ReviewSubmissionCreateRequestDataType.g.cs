
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        ReviewSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionCreateRequestDataType value)
        {
            return value switch
            {
                ReviewSubmissionCreateRequestDataType.ReviewSubmissions => "reviewSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "reviewSubmissions" => ReviewSubmissionCreateRequestDataType.ReviewSubmissions,
                _ => null,
            };
        }
    }
}