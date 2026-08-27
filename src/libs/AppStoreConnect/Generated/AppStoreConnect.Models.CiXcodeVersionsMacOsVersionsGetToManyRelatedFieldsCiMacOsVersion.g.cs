
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiMacOsVersion
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
    public static class CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiMacOsVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiMacOsVersion value)
        {
            return value switch
            {
                CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiMacOsVersion.Name => "name",
                CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiMacOsVersion.Version => "version",
                CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiMacOsVersion.XcodeVersions => "xcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiMacOsVersion? ToEnum(string value)
        {
            return value switch
            {
                "name" => CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiMacOsVersion.Name,
                "version" => CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiMacOsVersion.Version,
                "xcodeVersions" => CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiMacOsVersion.XcodeVersions,
                _ => null,
            };
        }
    }
}