
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaDetailsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Build,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBetaDetailsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BuildBetaDetailsGetInstanceIncludeItem.Build => "build",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "build" => BuildBetaDetailsGetInstanceIncludeItem.Build,
                _ => null,
            };
        }
    }
}