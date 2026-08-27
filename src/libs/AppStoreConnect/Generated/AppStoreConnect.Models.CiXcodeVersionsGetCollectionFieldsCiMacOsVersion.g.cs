
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiXcodeVersionsGetCollectionFieldsCiMacOsVersion
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
    public static class CiXcodeVersionsGetCollectionFieldsCiMacOsVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiXcodeVersionsGetCollectionFieldsCiMacOsVersion value)
        {
            return value switch
            {
                CiXcodeVersionsGetCollectionFieldsCiMacOsVersion.Name => "name",
                CiXcodeVersionsGetCollectionFieldsCiMacOsVersion.Version => "version",
                CiXcodeVersionsGetCollectionFieldsCiMacOsVersion.XcodeVersions => "xcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiXcodeVersionsGetCollectionFieldsCiMacOsVersion? ToEnum(string value)
        {
            return value switch
            {
                "name" => CiXcodeVersionsGetCollectionFieldsCiMacOsVersion.Name,
                "version" => CiXcodeVersionsGetCollectionFieldsCiMacOsVersion.Version,
                "xcodeVersions" => CiXcodeVersionsGetCollectionFieldsCiMacOsVersion.XcodeVersions,
                _ => null,
            };
        }
    }
}