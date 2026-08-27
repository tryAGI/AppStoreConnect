
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersion
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
    public static class CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersion value)
        {
            return value switch
            {
                CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersion.MacOsVersions => "macOsVersions",
                CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersion.Name => "name",
                CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersion.TestDestinations => "testDestinations",
                CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "macOsVersions" => CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersion.MacOsVersions,
                "name" => CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersion.Name,
                "testDestinations" => CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersion.TestDestinations,
                "version" => CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersion.Version,
                _ => null,
            };
        }
    }
}