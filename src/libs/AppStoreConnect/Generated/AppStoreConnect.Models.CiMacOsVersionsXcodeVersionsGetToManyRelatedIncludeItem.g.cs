
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiMacOsVersionsXcodeVersionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        MacOsVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiMacOsVersionsXcodeVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiMacOsVersionsXcodeVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                CiMacOsVersionsXcodeVersionsGetToManyRelatedIncludeItem.MacOsVersions => "macOsVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiMacOsVersionsXcodeVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "macOsVersions" => CiMacOsVersionsXcodeVersionsGetToManyRelatedIncludeItem.MacOsVersions,
                _ => null,
            };
        }
    }
}