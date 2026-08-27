
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppBetaAppReviewDetailLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaAppReviewDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppBetaAppReviewDetailLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppBetaAppReviewDetailLinkageResponseDataType value)
        {
            return value switch
            {
                AppBetaAppReviewDetailLinkageResponseDataType.BetaAppReviewDetails => "betaAppReviewDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppBetaAppReviewDetailLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaAppReviewDetails" => AppBetaAppReviewDetailLinkageResponseDataType.BetaAppReviewDetails,
                _ => null,
            };
        }
    }
}