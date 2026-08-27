
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativeDistributionPackagesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativeDistributionPackagesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativeDistributionPackagesGetInstanceIncludeItem value)
        {
            return value switch
            {
                AlternativeDistributionPackagesGetInstanceIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativeDistributionPackagesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "versions" => AlternativeDistributionPackagesGetInstanceIncludeItem.Versions,
                _ => null,
            };
        }
    }
}