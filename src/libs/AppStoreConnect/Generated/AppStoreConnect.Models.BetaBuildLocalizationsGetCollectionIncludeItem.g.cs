
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaBuildLocalizationsGetCollectionIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Build,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBuildLocalizationsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBuildLocalizationsGetCollectionIncludeItem value)
        {
            return value switch
            {
                BetaBuildLocalizationsGetCollectionIncludeItem.Build => "build",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBuildLocalizationsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "build" => BetaBuildLocalizationsGetCollectionIncludeItem.Build,
                _ => null,
            };
        }
    }
}