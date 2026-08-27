
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppReviewSubmissionCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppReviewSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppReviewSubmissionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewSubmissionCreateRequestDataType value)
        {
            return value switch
            {
                BetaAppReviewSubmissionCreateRequestDataType.BetaAppReviewSubmissions => "betaAppReviewSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewSubmissionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppReviewSubmissions" => BetaAppReviewSubmissionCreateRequestDataType.BetaAppReviewSubmissions,
                _ => null,
            };
        }
    }
}