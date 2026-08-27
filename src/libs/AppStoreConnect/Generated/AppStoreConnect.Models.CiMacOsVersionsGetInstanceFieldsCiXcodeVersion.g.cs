
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiMacOsVersionsGetInstanceFieldsCiXcodeVersion
    {
        /// <summary>
        /// 
        /// </summary>
        MacOsVersions,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        TestDestinations,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiMacOsVersionsGetInstanceFieldsCiXcodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiMacOsVersionsGetInstanceFieldsCiXcodeVersion value)
        {
            return value switch
            {
                CiMacOsVersionsGetInstanceFieldsCiXcodeVersion.MacOsVersions => "macOsVersions",
                CiMacOsVersionsGetInstanceFieldsCiXcodeVersion.Name => "name",
                CiMacOsVersionsGetInstanceFieldsCiXcodeVersion.TestDestinations => "testDestinations",
                CiMacOsVersionsGetInstanceFieldsCiXcodeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiMacOsVersionsGetInstanceFieldsCiXcodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "macOsVersions" => CiMacOsVersionsGetInstanceFieldsCiXcodeVersion.MacOsVersions,
                "name" => CiMacOsVersionsGetInstanceFieldsCiXcodeVersion.Name,
                "testDestinations" => CiMacOsVersionsGetInstanceFieldsCiXcodeVersion.TestDestinations,
                "version" => CiMacOsVersionsGetInstanceFieldsCiXcodeVersion.Version,
                _ => null,
            };
        }
    }
}