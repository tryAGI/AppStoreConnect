
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PassTypeIdsGetCollectionIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PassTypeIdsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdsGetCollectionIncludeItem value)
        {
            return value switch
            {
                PassTypeIdsGetCollectionIncludeItem.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => PassTypeIdsGetCollectionIncludeItem.Certificates,
                _ => null,
            };
        }
    }
}