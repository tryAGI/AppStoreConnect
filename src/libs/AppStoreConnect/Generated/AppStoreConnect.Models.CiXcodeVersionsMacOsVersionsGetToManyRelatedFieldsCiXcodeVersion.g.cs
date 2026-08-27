
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersion
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
    public static class CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersion value)
        {
            return value switch
            {
                CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersion.MacOsVersions => "macOsVersions",
                CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersion.Name => "name",
                CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersion.TestDestinations => "testDestinations",
                CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "macOsVersions" => CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersion.MacOsVersions,
                "name" => CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersion.Name,
                "testDestinations" => CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersion.TestDestinations,
                "version" => CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersion.Version,
                _ => null,
            };
        }
    }
}