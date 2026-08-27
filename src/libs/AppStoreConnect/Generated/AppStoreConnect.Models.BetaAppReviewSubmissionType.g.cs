
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppReviewSubmissionType
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppReviewSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppReviewSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewSubmissionType value)
        {
            return value switch
            {
                BetaAppReviewSubmissionType.BetaAppReviewSubmissions => "betaAppReviewSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppReviewSubmissions" => BetaAppReviewSubmissionType.BetaAppReviewSubmissions,
                _ => null,
            };
        }
    }
}