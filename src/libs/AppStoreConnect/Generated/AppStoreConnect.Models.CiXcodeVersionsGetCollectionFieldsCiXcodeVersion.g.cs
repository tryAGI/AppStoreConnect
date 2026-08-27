
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiXcodeVersionsGetCollectionFieldsCiXcodeVersion
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
    public static class CiXcodeVersionsGetCollectionFieldsCiXcodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiXcodeVersionsGetCollectionFieldsCiXcodeVersion value)
        {
            return value switch
            {
                CiXcodeVersionsGetCollectionFieldsCiXcodeVersion.MacOsVersions => "macOsVersions",
                CiXcodeVersionsGetCollectionFieldsCiXcodeVersion.Name => "name",
                CiXcodeVersionsGetCollectionFieldsCiXcodeVersion.TestDestinations => "testDestinations",
                CiXcodeVersionsGetCollectionFieldsCiXcodeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiXcodeVersionsGetCollectionFieldsCiXcodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "macOsVersions" => CiXcodeVersionsGetCollectionFieldsCiXcodeVersion.MacOsVersions,
                "name" => CiXcodeVersionsGetCollectionFieldsCiXcodeVersion.Name,
                "testDestinations" => CiXcodeVersionsGetCollectionFieldsCiXcodeVersion.TestDestinations,
                "version" => CiXcodeVersionsGetCollectionFieldsCiXcodeVersion.Version,
                _ => null,
            };
        }
    }
}