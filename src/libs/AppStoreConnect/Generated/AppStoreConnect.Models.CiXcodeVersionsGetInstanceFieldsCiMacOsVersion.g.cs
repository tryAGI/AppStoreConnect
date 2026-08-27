
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiXcodeVersionsGetInstanceFieldsCiMacOsVersion
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
    public static class CiXcodeVersionsGetInstanceFieldsCiMacOsVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiXcodeVersionsGetInstanceFieldsCiMacOsVersion value)
        {
            return value switch
            {
                CiXcodeVersionsGetInstanceFieldsCiMacOsVersion.Name => "name",
                CiXcodeVersionsGetInstanceFieldsCiMacOsVersion.Version => "version",
                CiXcodeVersionsGetInstanceFieldsCiMacOsVersion.XcodeVersions => "xcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiXcodeVersionsGetInstanceFieldsCiMacOsVersion? ToEnum(string value)
        {
            return value switch
            {
                "name" => CiXcodeVersionsGetInstanceFieldsCiMacOsVersion.Name,
                "version" => CiXcodeVersionsGetInstanceFieldsCiMacOsVersion.Version,
                "xcodeVersions" => CiXcodeVersionsGetInstanceFieldsCiMacOsVersion.XcodeVersions,
                _ => null,
            };
        }
    }
}