
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiMacOsVersion
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
    public static class CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiMacOsVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiMacOsVersion value)
        {
            return value switch
            {
                CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiMacOsVersion.Name => "name",
                CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiMacOsVersion.Version => "version",
                CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiMacOsVersion.XcodeVersions => "xcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiMacOsVersion? ToEnum(string value)
        {
            return value switch
            {
                "name" => CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiMacOsVersion.Name,
                "version" => CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiMacOsVersion.Version,
                "xcodeVersions" => CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiMacOsVersion.XcodeVersions,
                _ => null,
            };
        }
    }
}