
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildRelationshipsBetaAppReviewSubmissionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppReviewSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildRelationshipsBetaAppReviewSubmissionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildRelationshipsBetaAppReviewSubmissionDataType value)
        {
            return value switch
            {
                BuildRelationshipsBetaAppReviewSubmissionDataType.BetaAppReviewSubmissions => "betaAppReviewSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildRelationshipsBetaAppReviewSubmissionDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppReviewSubmissions" => BuildRelationshipsBetaAppReviewSubmissionDataType.BetaAppReviewSubmissions,
                _ => null,
            };
        }
    }
}