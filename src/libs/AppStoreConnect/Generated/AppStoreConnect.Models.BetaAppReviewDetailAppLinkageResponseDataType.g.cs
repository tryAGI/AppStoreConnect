
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppReviewDetailAppLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppReviewDetailAppLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewDetailAppLinkageResponseDataType value)
        {
            return value switch
            {
                BetaAppReviewDetailAppLinkageResponseDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewDetailAppLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BetaAppReviewDetailAppLinkageResponseDataType.Apps,
                _ => null,
            };
        }
    }
}