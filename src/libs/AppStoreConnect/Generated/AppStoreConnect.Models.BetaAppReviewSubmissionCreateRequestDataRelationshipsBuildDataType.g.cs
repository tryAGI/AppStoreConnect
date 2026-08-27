
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppReviewSubmissionCreateRequestDataRelationshipsBuildDataType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppReviewSubmissionCreateRequestDataRelationshipsBuildDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewSubmissionCreateRequestDataRelationshipsBuildDataType value)
        {
            return value switch
            {
                BetaAppReviewSubmissionCreateRequestDataRelationshipsBuildDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewSubmissionCreateRequestDataRelationshipsBuildDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BetaAppReviewSubmissionCreateRequestDataRelationshipsBuildDataType.Builds,
                _ => null,
            };
        }
    }
}