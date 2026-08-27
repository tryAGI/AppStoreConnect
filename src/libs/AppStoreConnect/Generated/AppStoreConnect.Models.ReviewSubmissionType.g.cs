
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionType
    {
        /// <summary>
        /// 
        /// </summary>
        ReviewSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionType value)
        {
            return value switch
            {
                ReviewSubmissionType.ReviewSubmissions => "reviewSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "reviewSubmissions" => ReviewSubmissionType.ReviewSubmissions,
                _ => null,
            };
        }
    }
}