
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppLocalizationsGetCollectionIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAppLocalizationsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppLocalizationsGetCollectionIncludeItem value)
        {
            return value switch
            {
                BetaAppLocalizationsGetCollectionIncludeItem.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppLocalizationsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaAppLocalizationsGetCollectionIncludeItem.App,
                _ => null,
            };
        }
    }
}