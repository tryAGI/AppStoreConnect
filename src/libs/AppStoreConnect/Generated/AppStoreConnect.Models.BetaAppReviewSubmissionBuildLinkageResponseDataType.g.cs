
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppReviewSubmissionBuildLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppReviewSubmissionBuildLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewSubmissionBuildLinkageResponseDataType value)
        {
            return value switch
            {
                BetaAppReviewSubmissionBuildLinkageResponseDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewSubmissionBuildLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BetaAppReviewSubmissionBuildLinkageResponseDataType.Builds,
                _ => null,
            };
        }
    }
}