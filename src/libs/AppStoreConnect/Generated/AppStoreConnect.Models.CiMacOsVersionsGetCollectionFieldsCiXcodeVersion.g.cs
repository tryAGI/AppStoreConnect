
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiMacOsVersionsGetCollectionFieldsCiXcodeVersion
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
    public static class CiMacOsVersionsGetCollectionFieldsCiXcodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiMacOsVersionsGetCollectionFieldsCiXcodeVersion value)
        {
            return value switch
            {
                CiMacOsVersionsGetCollectionFieldsCiXcodeVersion.MacOsVersions => "macOsVersions",
                CiMacOsVersionsGetCollectionFieldsCiXcodeVersion.Name => "name",
                CiMacOsVersionsGetCollectionFieldsCiXcodeVersion.TestDestinations => "testDestinations",
                CiMacOsVersionsGetCollectionFieldsCiXcodeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiMacOsVersionsGetCollectionFieldsCiXcodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "macOsVersions" => CiMacOsVersionsGetCollectionFieldsCiXcodeVersion.MacOsVersions,
                "name" => CiMacOsVersionsGetCollectionFieldsCiXcodeVersion.Name,
                "testDestinations" => CiMacOsVersionsGetCollectionFieldsCiXcodeVersion.TestDestinations,
                "version" => CiMacOsVersionsGetCollectionFieldsCiXcodeVersion.Version,
                _ => null,
            };
        }
    }
}