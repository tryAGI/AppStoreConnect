
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppRelationshipsBetaAppReviewDetailDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsBetaAppReviewDetailDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsBetaAppReviewDetailDataType value)
        {
            return value switch
            {
                AppRelationshipsBetaAppReviewDetailDataType.BetaAppReviewDetails => "betaAppReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsBetaAppReviewDetailDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppReviewDetails" => AppRelationshipsBetaAppReviewDetailDataType.BetaAppReviewDetails,
                _ => null,
            };
        }
    }
}