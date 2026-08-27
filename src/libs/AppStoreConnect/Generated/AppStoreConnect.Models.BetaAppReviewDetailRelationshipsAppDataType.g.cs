
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppReviewDetailRelationshipsAppDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppReviewDetailRelationshipsAppDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewDetailRelationshipsAppDataType value)
        {
            return value switch
            {
                BetaAppReviewDetailRelationshipsAppDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewDetailRelationshipsAppDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BetaAppReviewDetailRelationshipsAppDataType.Apps,
                _ => null,
            };
        }
    }
}