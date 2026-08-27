
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppReviewSubmissionsGetCollectionIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Build,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppReviewSubmissionsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewSubmissionsGetCollectionIncludeItem value)
        {
            return value switch
            {
                BetaAppReviewSubmissionsGetCollectionIncludeItem.Build => "build",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewSubmissionsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "build" => BetaAppReviewSubmissionsGetCollectionIncludeItem.Build,
                _ => null,
            };
        }
    }
}