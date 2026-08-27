
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaDetailsGetCollectionIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Build,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBetaDetailsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsGetCollectionIncludeItem value)
        {
            return value switch
            {
                BuildBetaDetailsGetCollectionIncludeItem.Build => "build",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "build" => BuildBetaDetailsGetCollectionIncludeItem.Build,
                _ => null,
            };
        }
    }
}