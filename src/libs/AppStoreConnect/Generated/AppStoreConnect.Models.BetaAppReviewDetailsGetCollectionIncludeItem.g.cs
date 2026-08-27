
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppReviewDetailsGetCollectionIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppReviewDetailsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewDetailsGetCollectionIncludeItem value)
        {
            return value switch
            {
                BetaAppReviewDetailsGetCollectionIncludeItem.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewDetailsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaAppReviewDetailsGetCollectionIncludeItem.App,
                _ => null,
            };
        }
    }
}