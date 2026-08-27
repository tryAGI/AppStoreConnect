
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PassTypeIdsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PassTypeIdsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdsGetInstanceIncludeItem value)
        {
            return value switch
            {
                PassTypeIdsGetInstanceIncludeItem.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => PassTypeIdsGetInstanceIncludeItem.Certificates,
                _ => null,
            };
        }
    }
}