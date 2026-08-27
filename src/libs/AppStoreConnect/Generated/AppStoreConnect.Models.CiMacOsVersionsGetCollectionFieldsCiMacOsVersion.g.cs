
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiMacOsVersionsGetCollectionFieldsCiMacOsVersion
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
    public static class CiMacOsVersionsGetCollectionFieldsCiMacOsVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiMacOsVersionsGetCollectionFieldsCiMacOsVersion value)
        {
            return value switch
            {
                CiMacOsVersionsGetCollectionFieldsCiMacOsVersion.Name => "name",
                CiMacOsVersionsGetCollectionFieldsCiMacOsVersion.Version => "version",
                CiMacOsVersionsGetCollectionFieldsCiMacOsVersion.XcodeVersions => "xcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiMacOsVersionsGetCollectionFieldsCiMacOsVersion? ToEnum(string value)
        {
            return value switch
            {
                "name" => CiMacOsVersionsGetCollectionFieldsCiMacOsVersion.Name,
                "version" => CiMacOsVersionsGetCollectionFieldsCiMacOsVersion.Version,
                "xcodeVersions" => CiMacOsVersionsGetCollectionFieldsCiMacOsVersion.XcodeVersions,
                _ => null,
            };
        }
    }
}