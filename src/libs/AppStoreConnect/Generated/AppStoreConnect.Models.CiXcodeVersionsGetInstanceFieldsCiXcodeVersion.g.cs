
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiXcodeVersionsGetInstanceFieldsCiXcodeVersion
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
    public static class CiXcodeVersionsGetInstanceFieldsCiXcodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiXcodeVersionsGetInstanceFieldsCiXcodeVersion value)
        {
            return value switch
            {
                CiXcodeVersionsGetInstanceFieldsCiXcodeVersion.MacOsVersions => "macOsVersions",
                CiXcodeVersionsGetInstanceFieldsCiXcodeVersion.Name => "name",
                CiXcodeVersionsGetInstanceFieldsCiXcodeVersion.TestDestinations => "testDestinations",
                CiXcodeVersionsGetInstanceFieldsCiXcodeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiXcodeVersionsGetInstanceFieldsCiXcodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "macOsVersions" => CiXcodeVersionsGetInstanceFieldsCiXcodeVersion.MacOsVersions,
                "name" => CiXcodeVersionsGetInstanceFieldsCiXcodeVersion.Name,
                "testDestinations" => CiXcodeVersionsGetInstanceFieldsCiXcodeVersion.TestDestinations,
                "version" => CiXcodeVersionsGetInstanceFieldsCiXcodeVersion.Version,
                _ => null,
            };
        }
    }
}