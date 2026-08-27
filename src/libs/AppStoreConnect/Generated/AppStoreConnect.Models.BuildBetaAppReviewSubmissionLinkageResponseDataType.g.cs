
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaAppReviewSubmissionLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppReviewSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBetaAppReviewSubmissionLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaAppReviewSubmissionLinkageResponseDataType value)
        {
            return value switch
            {
                BuildBetaAppReviewSubmissionLinkageResponseDataType.BetaAppReviewSubmissions => "betaAppReviewSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaAppReviewSubmissionLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppReviewSubmissions" => BuildBetaAppReviewSubmissionLinkageResponseDataType.BetaAppReviewSubmissions,
                _ => null,
            };
        }
    }
}