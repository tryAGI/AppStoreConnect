
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiXcodeVersionsGetCollectionIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        MacOsVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiXcodeVersionsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiXcodeVersionsGetCollectionIncludeItem value)
        {
            return value switch
            {
                CiXcodeVersionsGetCollectionIncludeItem.MacOsVersions => "macOsVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiXcodeVersionsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "macOsVersions" => CiXcodeVersionsGetCollectionIncludeItem.MacOsVersions,
                _ => null,
            };
        }
    }
}