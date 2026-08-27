
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum TerritoryInlineCreateType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TerritoryInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TerritoryInlineCreateType value)
        {
            return value switch
            {
                TerritoryInlineCreateType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TerritoryInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => TerritoryInlineCreateType.Territories,
                _ => null,
            };
        }
    }
}