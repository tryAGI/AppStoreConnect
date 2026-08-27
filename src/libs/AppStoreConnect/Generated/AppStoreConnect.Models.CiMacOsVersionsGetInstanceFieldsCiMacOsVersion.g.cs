
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiMacOsVersionsGetInstanceFieldsCiMacOsVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Version,
        /// <summary>
        /// 
        /// </summary>
        XcodeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiMacOsVersionsGetInstanceFieldsCiMacOsVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiMacOsVersionsGetInstanceFieldsCiMacOsVersion value)
        {
            return value switch
            {
                CiMacOsVersionsGetInstanceFieldsCiMacOsVersion.Name => "name",
                CiMacOsVersionsGetInstanceFieldsCiMacOsVersion.Version => "version",
                CiMacOsVersionsGetInstanceFieldsCiMacOsVersion.XcodeVersions => "xcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiMacOsVersionsGetInstanceFieldsCiMacOsVersion? ToEnum(string value)
        {
            return value switch
            {
                "name" => CiMacOsVersionsGetInstanceFieldsCiMacOsVersion.Name,
                "version" => CiMacOsVersionsGetInstanceFieldsCiMacOsVersion.Version,
                "xcodeVersions" => CiMacOsVersionsGetInstanceFieldsCiMacOsVersion.XcodeVersions,
                _ => null,
            };
        }
    }
}