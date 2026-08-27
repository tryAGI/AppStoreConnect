
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAppReviewSubmissionsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Build,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppReviewSubmissionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewSubmissionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BetaAppReviewSubmissionsGetInstanceIncludeItem.Build => "build",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewSubmissionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "build" => BetaAppReviewSubmissionsGetInstanceIncludeItem.Build,
                _ => null,
            };
        }
    }
}