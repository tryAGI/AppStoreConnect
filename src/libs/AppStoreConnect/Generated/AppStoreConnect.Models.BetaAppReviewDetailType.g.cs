
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppReviewDetailType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppReviewDetailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewDetailType value)
        {
            return value switch
            {
                BetaAppReviewDetailType.BetaAppReviewDetails => "betaAppReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewDetailType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppReviewDetails" => BetaAppReviewDetailType.BetaAppReviewDetails,
                _ => null,
            };
        }
    }
}