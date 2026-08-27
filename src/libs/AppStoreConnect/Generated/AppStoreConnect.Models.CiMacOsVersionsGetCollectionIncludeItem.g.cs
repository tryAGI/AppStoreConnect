
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiMacOsVersionsGetCollectionIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        XcodeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiMacOsVersionsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiMacOsVersionsGetCollectionIncludeItem value)
        {
            return value switch
            {
                CiMacOsVersionsGetCollectionIncludeItem.XcodeVersions => "xcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiMacOsVersionsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "xcodeVersions" => CiMacOsVersionsGetCollectionIncludeItem.XcodeVersions,
                _ => null,
            };
        }
    }
}