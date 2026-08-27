
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunBuildsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunBuildsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunBuildsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                CiBuildRunBuildsLinkagesResponseDataItemType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunBuildsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => CiBuildRunBuildsLinkagesResponseDataItemType.Builds,
                _ => null,
            };
        }
    }
}