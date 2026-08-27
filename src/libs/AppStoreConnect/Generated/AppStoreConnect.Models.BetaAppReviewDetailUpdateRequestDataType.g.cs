
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppReviewDetailUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaAppReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppReviewDetailUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewDetailUpdateRequestDataType value)
        {
            return value switch
            {
                BetaAppReviewDetailUpdateRequestDataType.BetaAppReviewDetails => "betaAppReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewDetailUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppReviewDetails" => BetaAppReviewDetailUpdateRequestDataType.BetaAppReviewDetails,
                _ => null,
            };
        }
    }
}