
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppReviewDetailsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppReviewDetailsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewDetailsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BetaAppReviewDetailsGetInstanceIncludeItem.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewDetailsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaAppReviewDetailsGetInstanceIncludeItem.App,
                _ => null,
            };
        }
    }
}